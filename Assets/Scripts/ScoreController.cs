using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public GameObject playerWon;

    public int goalsToWin;

    public void GoalPlayer1()
    {
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {
        this.scorePlayer2++;
    }

    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (scorePlayer1 >= goalsToWin || scorePlayer2 >= goalsToWin)
        {
            SceneManager.LoadScene(2);
            Text uiPlayerWon = this.playerWon.GetComponent<Text>();

            if(scorePlayer1 > scorePlayer2)
            {
                uiPlayerWon.text = "Player1 Won";
            } else
            {
                uiPlayerWon.text = "Player2 Won";
            }
        }
    }
}
