using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienControl : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Animator myAnimation;
    public float jumpForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }
        myAnimation.SetFloat("vVelocity", myRigidbody.velocity.y);
    }
}
