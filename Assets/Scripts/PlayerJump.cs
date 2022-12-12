using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public Vector2 jump;
    public float jumpForce = 3.0f;

    public bool isGrounded;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 500.0f);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("sciana"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D()
    {
        isGrounded = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    private void FixedUpdate()
    {
        
    }

    //public Vector2 jumpForce = new Vector2(0f, 1500f);
    //bool isJumping = false;
    //public int jumpMaxNumber = 2;
    //int jumpNumber = 0;
    //Rigidbody2D rb;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        Debug.Log("abc");
    //        isJumping = true;
    //        jumpNumber++;
    //    }
    //}

    //private void FixedUpdate()
    //{
    //    Jump();
    //}

    //private void Jump()
    //{
    //    if (isJumping && jumpNumber <= jumpMaxNumber)
    //    {
    //        rb.AddForce(jumpForce, ForceMode2D.Impulse);

    //        isJumping = false;
    //    }

    //    if(Mathf.Abs(rb.velocity.y) < 0.1f)
    //    {
    //        jumpNumber = 0;
    //    }

    //}


}
