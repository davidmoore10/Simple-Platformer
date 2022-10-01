using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float moveSpeed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        platformMovement();
    }

    void platformMovement()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(5f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-5f, 0f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(0f, 5f);
        }
    }

    void topDownMovement()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput * moveSpeed * Time.deltaTime, verticalInput * moveSpeed * Time.deltaTime, 0);
        transform.Translate(movement);
    }
}
