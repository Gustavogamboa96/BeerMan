using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//#pragma strict 
public class move : MonoBehaviour {
    public float speed;
    public Vector2 jumpHeight, xSpeed, ySpeed;
    Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
    public bool grounded, canJump;
    public int jumpCount = 0;
    public int maxJumps = 2;

    // This function is called just one time by Unity the moment the game loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            if (mySpriteRenderer != null)
            {

                // flip the sprite
                mySpriteRenderer.flipX = true;

            }
            GetComponent<Rigidbody2D>().AddForce(ySpeed, ForceMode2D.Impulse);
            anim.SetTrigger("on movement");
            
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (mySpriteRenderer != null)
            {

                // flip the sprite
                mySpriteRenderer.flipX = false;

            }
            GetComponent<Rigidbody2D>().AddForce(xSpeed, ForceMode2D.Impulse);
            anim.SetTrigger("on movement");
            
        }
        
        //transform.Translate(speed * Time.deltaTime, 0f, 0f);  //makes player run

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            
           
            
                Jump();
            
            
        }
        
    }
   public void Jump()
        {
        jumpCount += 1;

        if(jumpCount <= maxJumps)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight.y);
            //GetComponent<Rigidbody2D>().velocity(jumpHeight);
            anim.SetTrigger("spacebar");
        }
        
            
        }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "floor(Clone)" || col.gameObject.name == "keg(Clone)" )
        {
           // grounded = true;
            jumpCount = 0;
        }
       
    }

}


