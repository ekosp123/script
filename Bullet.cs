using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Update is called on
    void start()
    {
        rb.velocity = transform.right * speed;
    }
}
