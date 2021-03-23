using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1Movement : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;
    }
}
