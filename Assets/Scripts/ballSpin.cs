using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpin : MonoBehaviour
{
    public bool touchingShrine = false;

    // Update is called once per frame
    void Update()
    {
        if (!touchingShrine)
        {
            transform.Rotate(0f, 0f, 2f * Time.deltaTime); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "shrine1" | collision.gameObject.name == "shrine2" | collision.gameObject.name == "shrine3")
        {
            Debug.Log("Collision with container detected, stopping rotation.");
            touchingShrine = true;
            GetComponent<Rigidbody2D>().angularVelocity = 0;

        }
    }
}

