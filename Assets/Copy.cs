using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy : MonoBehaviour

    
{

    public Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        //rigidBody2D.rotation = 100f;
    }

    void Update()
    {
        //rigidBody2D.rotation += -1.0f;



        if (Input.GetButtonDown("Jump"))
        {
            rigidBody2D.rotation += 20.0f;
        }

        else
        {
            transform.Rotate(new Vector3(0, 0, -40 * Time.deltaTime));
        }

        Vector3 euler = transform.eulerAngles;
        if (euler.z > 180) euler.z = euler.z - 360;
        euler.z = Mathf.Clamp(euler.z, -25, 50);
        transform.eulerAngles = euler;

    }


}
    

    
