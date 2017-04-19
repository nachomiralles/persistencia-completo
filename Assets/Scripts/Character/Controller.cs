using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    float velocity = 10.0f;
    bool mirandoDerecha = true;

    Animator anim;
    Rigidbody2D miRigidBody;

    void Start()
    {
        miRigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }


	void FixedUpdate () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        miRigidBody.velocity = new Vector2(moveX * velocity, moveY * velocity);
        anim.SetFloat("h_velocity", moveX);
        anim.SetFloat("v_velocity", moveY);

    }
}
