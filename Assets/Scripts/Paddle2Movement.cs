using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Movement : MonoBehaviour
{
    public float speed;

    public GameObject ball;


    // Update is called once per frame
    //private void Update()
    //{
    //    var v = Input.GetAxisRaw("Vertical2");

    //    GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed; 
    //}

    // AI Update mode
    private void FixedUpdate()
    {
        Vector3 ballPosition = ball.transform.position;
        Vector3 racketPosition = this.transform.position;
        
        if(Mathf.Abs(ballPosition.y - racketPosition.y) > 50)
        {
            Vector2 v;

            if (ballPosition.y > racketPosition.y)
            {
                v = Vector2.up;
            }
            else
            {
                v = Vector2.down;
            }

            GetComponent<Rigidbody2D>().velocity = v * speed;
        }
    }
}
