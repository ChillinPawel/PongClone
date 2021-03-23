using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Paddle1")
            x = 1;
        else
            x = -1;

            

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));

     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Paddle1" || collision.gameObject.name == "Paddle2")
        {
            this.BounceFromRacket(collision);
        } else if (collision.gameObject.name == "LeftWall")
        {
            scoreController.GoalPlayer2();
            StartCoroutine(ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "RightWall")
        {
            scoreController.GoalPlayer1();
            StartCoroutine(ballMovement.StartBall(false));
        }

        
    }
}
