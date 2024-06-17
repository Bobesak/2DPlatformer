using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D strom;
    public int JumpAvailable = 50;
    public AudioSource ad;
    public float maxSpeed = 10f; // Nastav� maxim�ln� rychlost

    void FixedUpdate()
    {
        // Kontroluje�, zda rychlost objektu nep�ekro�ila maxim�ln� rychlost
        if (strom.velocity.magnitude > maxSpeed)
        {
            // Pokud ano, omez� rychlost na maxim�ln� hodnotu
            strom.velocity = strom.velocity.normalized * maxSpeed;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        JumpAvailable = 50;
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.W) && JumpAvailable > 0)
        {
            strom.AddRelativeForce(new Vector2(0, 9));
            --JumpAvailable;
            ad.Play();
            
        }




        if (Input.GetKey(KeyCode.A))
        {
            strom.AddRelativeForce(new Vector2(-3, 0));
        }

        if (Input.GetKey(KeyCode.D))
        {
            strom.AddRelativeForce(new Vector2(3, 0));
        }
    }





}
