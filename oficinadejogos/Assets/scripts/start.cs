using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour

{
    
public string nivel1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            SceneManager.LoadScene(nivel1);
        }
        
       
    }
}
