using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public int IDPlayer;
    public float speed;
    public float jumpForce;
    public bool isJumping = false;
    public int checkpointsPassed;
    public Collider2D col;



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

        if (IDPlayer == 0)
        {
            
            if (Input.GetKey(KeyCode.Q))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }

        }

        if (IDPlayer == 1)
        {
            
            if (Input.GetKey(KeyCode.K))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.M))
            {
                transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        if (IDPlayer == 2)
        {
            
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        if (IDPlayer == 3)
        {
            
            if (Input.GetKey(KeyCode.Keypad1))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            else if (Input.GetKey(KeyCode.Keypad3))
            {
                transform.position += Vector3.left * -speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -45);
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("checkpoint"))
        {
            checkpointsPassed++;
        }
    }
}
