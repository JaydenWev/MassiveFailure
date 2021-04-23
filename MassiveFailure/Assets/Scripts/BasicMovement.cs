using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BasicMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody rigid;
    // Update is called once per frame
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal"); // Get axis normalizes the vectors
        float zDirection = Input.GetAxis("Vertical");   // Allowing you to move diagonally

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        //rigid.AddForce(moveDirection * speed);
        transform.position += moveDirection * speed;
    }
}
