using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour 
{

    Rigidbody myRigidBody;
    public float speed = 1f;
    Vector3 zeroVeocity;


	void Start ()
	{
	    myRigidBody = GetComponent<Rigidbody>();
	    zeroVeocity = Vector3.zero; //vector to stop velocity
	}

    void Update()
    {
        //MoveUp();
        //MoveDown();
        //ConstantMovement();
        Acell();
    }


    private void Acell()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            myRigidBody.velocity = Vector3.back * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.O))
        {
            myRigidBody.velocity += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.I))
        {
            myRigidBody.velocity -= Vector3.back * speed * Time.deltaTime;
        }


    }

    /*
    private void MoveUp()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            myRigidBody.velocity = Vector3.up;
        }
        if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            myRigidBody.velocity = zeroVeocity;
        }
    }

    void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            myRigidBody.velocity = Vector3.down;
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            myRigidBody.velocity = zeroVeocity;
        }
    }


    void ConstantMovement()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            myRigidBody.velocity = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            myRigidBody.velocity = Vector3.down;
        }
        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            myRigidBody.velocity = zeroVeocity;
        }
    }
    */

}
