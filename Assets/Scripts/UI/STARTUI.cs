using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTUI : MonoBehaviour
{


    public void Scene()
    {
        SceneManager.LoadScene("PlayingScreen");
    }

    public void Respawn()
    {
        SceneManager.LoadScene("PlayScreen");
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
