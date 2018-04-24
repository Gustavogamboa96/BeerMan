using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class androidMove : MonoBehaviour {
    public AudioSource audiosource;
    public Rigidbody2D rb;
    Animator anim;
    public Vector2 xSpeed, jumpHeight;
    public int jumpCount = 0;
    public int maxJumps = 2;
    // Use this for initialization
    void Start () {
        audiosource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        GetComponent<Rigidbody2D>().AddForce(xSpeed, ForceMode2D.Impulse);
        anim.SetTrigger("on movement");
    

     if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            Jump();
        }
        
    }
   public void Jump()
{
    jumpCount += 1;

    if (jumpCount <= maxJumps)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight.y);
        //GetComponent<Rigidbody2D>().velocity(jumpHeight);
        anim.SetTrigger("spacebar");
    }


}

     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "cap(Clone)" || collision.gameObject.name == "cap")
            audiosource.Play();
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "floor(Clone)" || col.gameObject.name == "keg(Clone)" || col.gameObject.name == "floor2(Clone)")
        {
            // grounded = true;
            jumpCount = 0;
        }

        
    }
}

