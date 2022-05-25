using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float velocity = 0f;
    private float gravity = -2f;
    
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 3f, 0), ForceMode.Impulse);
    }
    
    
    /*
    private float bounceSpeed = 0.1f;
    private float bounceAmount = 2f;

    private bool isFallingDown = true;
    private bool isBouncing = false;

    private float velocity = 0f;
    private float gravity = -2f;

    private float bounceTime = 0f;
    private float bounceStartY = 0f;
    
    
    private void OnTriggerEnter(Collider other)
    {
        isFallingDown = false;
        isBouncing = true;
        bounceTime = 0;
        bounceStartY = transform.position.y;
        
        Debug.Log("Bounce!");
    }

    void Update()
    {
        if (isFallingDown)
        {
            velocity += gravity * Time.deltaTime;
            transform.position += new Vector3(0, velocity * Time.deltaTime, 0);
        }
        else if (isBouncing)
        {   
            transform.position = new Vector3(transform.position.x, bounceStartY + Bounce((bounceTime * bounceSpeed) % 1) * bounceAmount, transform.position.z);
            bounceTime += Time.deltaTime;

            if (bounceTime >= 1f)
            {
                isBouncing = false;
                isFallingDown = true;
                velocity = 0;
                Debug.Log("Falling!");
            }
        }
    }
    
    float Bounce (float t)
    {
        return Mathf.Sin(Mathf.Clamp01(t) * Mathf.PI);
    }
    */

}
