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
    public float maxSpeed = 10f; // Nastavíš maximální rychlost

    void FixedUpdate()
    {
        // Kontroluješ, zda rychlost objektu nepøekroèila maximální rychlost
        if (strom.velocity.magnitude > maxSpeed)
        {
            // Pokud ano, omezíš rychlost na maximální hodnotu
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
