using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kretanjeRibice : MonoBehaviour
{


    Rigidbody2D body;

    float vertical;

    public float runSpeed = 35.0f;
    private int _lives;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(0,vertical * runSpeed);
    }
}
