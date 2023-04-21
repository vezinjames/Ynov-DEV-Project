using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public TextMeshProUGUI winnerText; 

    private static string winner;

    private int nbJrs = 4;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player1.activeSelf)
        {
            nbJrs--;
        }
        if (!player2.activeSelf)
        {
            nbJrs--;
        }
        if (!player3.activeSelf)
        {
            nbJrs--;
        }
        if (!player4.activeSelf)
        {
            nbJrs--;
        }
        if(nbJrs == 1)
        {
            if (player1.activeSelf)
            {
                winner = player1.name;
            }
            if (player2.activeSelf)
            {
                winner = player2.name;
            }
            if (player3.activeSelf)
            {
                winner = player3.name;
            }
            if (player4.activeSelf)
            {
                winner = player4.name;
            }
            SceneManager.LoadScene("End");
        }
        winnerName();
    }

    private void winnerName()
    {
        if (SceneManager.GetActiveScene().name == "End")
        {
            winnerText.SetText(winner);
        }
    }
}
