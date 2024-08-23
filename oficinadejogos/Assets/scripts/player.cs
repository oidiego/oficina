using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rig;
    
    public float JumpForce;

    public bool isJumping;

    public bool doublejump;

    private Animator Anim;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();

    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f,0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            Anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") < 0f)
        {
            Anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") == 0f)
        {
            Anim.SetBool("walk", false);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
                doublejump = true;
                Anim.SetBool("jump", true);
            }
            else
            {
                if (doublejump)
                {
                    rig.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
                    doublejump = false;
                }
                
            }
           
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
            Anim.SetBool("jump", false);
        }
        
         if (collision.gameObject.tag == "spikes")
                {
                    controle.instance.ShowGamerOver();
                    Destroy(gameObject);
                }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;
        }
    }
}
