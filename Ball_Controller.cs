using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject paddle1;
    public GameObject paddle2;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        paddle1 = GameObject.Find("Paddle_1");
        paddle2 = GameObject.Find("Paddle_2");

        Count_Score.canAddScore = true;
        StartCoroutine(Pause());            //call coroutine method
    }

    // Update is called once per frame
    void Update()
    {
        //Ball Movement
        if (Mathf.Abs(this.transform.position.x) >= 19f)
        {
            Count_Score.canAddScore = true; 

            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause()
    { 
        //Ball Direction movement when play game
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);
        if (directionX == 0)
        {
            directionX = 1;
        }

        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);     //few wait for seconds start game
        rb.velocity = new Vector2(12f * directionX, 10f * directionY);      //when ball destroy then continue ball direction movement
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Ball movement direction when touch Paddle_1 
        if (collision.gameObject.name == "Paddle_1")
        {
            if (paddle1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(10f, 10f);
            }
            else if (paddle1.GetComponent<Rigidbody2D>().velocity.y > -0.5f)
            {
                rb.velocity = new Vector2(10f, -10f);
            }
            else
            {
                rb.velocity = new Vector2(12f, 0f);
            }
        }
        // Ball movement direction when touch Paddle_2
        if (collision.gameObject.name == "Paddle_2")
        {
            if (paddle2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-10f, 10f);
            }
            else if (paddle2.GetComponent<Rigidbody2D>().velocity.y > -0.5f)
            {
                rb.velocity = new Vector2(-10f, -10f);
            }
            else
            {
                rb.velocity = new Vector2(-12f, 0f);
            }
        }
    }
}
