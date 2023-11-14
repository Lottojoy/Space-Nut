using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public float moveSpeed = 50f;
    Vector2 movement;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HatAnim.canWalk)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            rb.AddForce(Vector2.right * 0, ForceMode2D.Impulse);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
