using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float bulletForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 3f);
    }

    void Update()
    {
        rb.velocity = new Vector2(bulletForce, rb.velocity.y);
    }
}
