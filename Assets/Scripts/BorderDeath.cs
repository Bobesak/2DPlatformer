using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDeath : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject Playingpart;
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Playingpart.SetActive(false);
        DeathScreen.SetActive(true);
    }



}

