using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlataform : MonoBehaviour
{

    public float fallingTime;

    private TargetJoint2D target;

    private BoxCollider2D boxColl;
    
    
    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           Invoke("falling", fallingTime);
        }
        
        if (collision.gameObject.layer == 9)
        {
           Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }

    void falling()
    {
        target.enabled = false;
        boxColl.isTrigger = true;
    }
   
}
