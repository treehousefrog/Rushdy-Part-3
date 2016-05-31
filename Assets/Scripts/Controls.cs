using UnityEngine;
using System.Collections;


public class Controls : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;
    public float jumpheight;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public int crystals;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    private Animator anim;
    
    

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        
    }

    // Update is called once per frame
    void Update () {

        if (crystals == 41)
        {
            Application.LoadLevel("level2");
        }

        if (rb.velocity.x != 0 && onGround)
        {
            anim.SetBool("Walking", true);
        } else
        {
            anim.SetBool("Walking", false);
        }



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
        }

        if (jump)
        {
            if (onGround)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
            }
            jump = false;
        }

        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }

    }
    
}
