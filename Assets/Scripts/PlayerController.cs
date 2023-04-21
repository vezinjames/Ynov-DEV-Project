using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int IDPlayer;
    public float speed;
    public float jumpForce;
    public int checkpointsPassed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundMask;
    private bool isTouchingGround;


    // Start is called before the first frame update
    void Start()
    {
        checkpointsPassed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    private void MovePlayer()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
        if (IDPlayer == 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                /*transform.rotation = Quaternion.Euler(0, 0, 45);*/

            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                //transform.position += Vector3.left * -speed * Time.deltaTime;
                /*transform.rotation = Quaternion.Euler(0, 0, -45);*/
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (isTouchingGround)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
                
            }
            

        }

        if (IDPlayer == 1)
        {
            
            if (Input.GetKey(KeyCode.K))
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                /*transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);*/
            }
            else if (Input.GetKey(KeyCode.M))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                /*transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);*/
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                if (isTouchingGround)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
            }
        }

        if (IDPlayer == 2)
        {
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                /*transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);*/
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                /*transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);*/
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (isTouchingGround)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
            }
        }

        if (IDPlayer == 3)
        {
            
            if (Input.GetKey(KeyCode.Keypad1))
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
                /*transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);*/
            }
            else if (Input.GetKey(KeyCode.Keypad3))
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
                /*transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);*/
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                if (isTouchingGround)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("checkpoint"))
        {
            if(collision.GetComponent<Ranking>().checkPointID > checkpointsPassed) { checkpointsPassed++; }
            
        }
    }
}
