using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if(collision.gameObject == player1)
        {
            player1.SetActive(false);
        }
        if (collision.gameObject == player2)
        {
            player2.SetActive(false);
        }
        if (collision.gameObject == player3)
        {
            player3.SetActive(false);
        }
        if (collision.gameObject == player4)
        {
            player4.SetActive(false);
        }
    }
}
