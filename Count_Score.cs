using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour
{
    public Text ScoreText;
    public GameObject ball;

    public static bool canAddScore;

    private int Paddle_1_Score = 0;
    private int Paddle_2_Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        //Score increment paddle_1 when ball out of game 
        if (ball.transform.position.x >= 19f && canAddScore)
        {
            canAddScore = false;
            Paddle_1_Score++;
        }
        //Score increment paddle_2 when ball out of game 
        if (ball.transform.position.x <= -19f && canAddScore)
        {
            canAddScore = false;
            Paddle_2_Score++;
        }
        //when paddle_1 score equal 7 then player win and load player_1_win scene
        if (Paddle_1_Score >= 7)
        {
            SceneManager.LoadScene(2);
        }
        //when paddle_2 score equal 7 then player win and load player_2_win scene
        if (Paddle_2_Score >= 7)
        {
            SceneManager.LoadScene(3);
        }

        ScoreText.text = Paddle_1_Score.ToString() + "  -  " + Paddle_2_Score.ToString();
    }
}
