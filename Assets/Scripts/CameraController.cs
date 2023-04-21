using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;
    public Transform target;
    public GameObject[] players;
    public Vector3 offset;
    public float damping;


    private Vector3 velocity;

    private void Start()
    { 
        target = player1;
        ComparePlace();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ComparePlace();
        Vector3 movePosition = target.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
    }

    private void ComparePlace()
    {
        if (player2.GetComponent<PlayerController>().checkpointsPassed > player1.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player2;
        }
        else if (player3.GetComponent<PlayerController>().checkpointsPassed > player1.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player3;
        }
        else if (player4.GetComponent<PlayerController>().checkpointsPassed > player1.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player4;
        }

        if (player1.GetComponent<PlayerController>().checkpointsPassed > player2.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player1;
        }
        else if (player3.GetComponent<PlayerController>().checkpointsPassed > player2.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player3;
        }
        else if (player4.GetComponent<PlayerController>().checkpointsPassed > player2.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player4;
        }

        if (player1.GetComponent<PlayerController>().checkpointsPassed > player3.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player1;
        }
        else if (player2.GetComponent<PlayerController>().checkpointsPassed > player3.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player2;
        }
        else if (player4.GetComponent<PlayerController>().checkpointsPassed > player3.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player4;
        }

        if (player1.GetComponent<PlayerController>().checkpointsPassed > player4.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player1;
        }
        else if (player2.GetComponent<PlayerController>().checkpointsPassed > player4.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player2;
        }
        else if (player3.GetComponent<PlayerController>().checkpointsPassed > player4.GetComponent<PlayerController>().checkpointsPassed)
        {
            target = player3;
        }

        /*foreach(GameObject p in players)
        {
            if (p.GetComponent<PlayerController>().checkpointsPassed > players[0].GetComponent<PlayerController>().checkpointsPassed)
            {
                target = p;
                Debug.Log(target);

                if (p.GetComponent<PlayerController>().checkpointsPassed > players[1].GetComponent<PlayerController>().checkpointsPassed)
                {
                    target = p;
                    if (p.GetComponent<PlayerController>().checkpointsPassed > players[2].GetComponent<PlayerController>().checkpointsPassed)
                    {
                        target = p;
                        if (p.GetComponent<PlayerController>().checkpointsPassed > players[3].GetComponent<PlayerController>().checkpointsPassed)
                        {
                            target = p;
                            
                        }
                    }
                }
            }
            else if(p.GetComponent<PlayerController>().checkpointsPassed == 0)
            {
                target = players[3];
            }
        }
        return target;*/
    }
}
