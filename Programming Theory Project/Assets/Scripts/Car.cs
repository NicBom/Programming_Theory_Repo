using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float speed = 10f;
    private float turnSpeed = 50f;
    int year = 1980;

    public float carSpeed
    {
        get { return speed; }
        set
        {
            if (value < 1)
            {
                Debug.LogError("Speed cannot be set below 1!");
            }
            else
            {
                speed = value;
            }
        }
    }

    public float carTurnSpeed
    {
        get { return turnSpeed; }
        set
        {
            if (value < 1)
            {
                Debug.LogError("Turning Speed cannot be set below 1!");
            }
            else
            {
                turnSpeed = value;
            }
        }
    }

    public int carYear
    {
        get { return year; }
        set
        {
            if (value < 1970)
            {
                Debug.LogError("Year Cannot be below 1970!");
            }
            else
            {
                carYear = value;
            }
        }
    }

    private float verticalInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        printCarYear();
    }

    public void SetSpeed(float speedSet)
    {
        carSpeed = speedSet;
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * verticalInput * carSpeed * Time.deltaTime);
    }

    private void Turn()
    {
        transform.Rotate(Vector3.up, horizontalInput * carTurnSpeed * Time.deltaTime);
    }

    public virtual void printCarYear()
    {
        Debug.Log("The car is a Car from " + carYear);
    }


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Move();
        verticalInput = Input.GetAxis("Vertical");
        Turn();
    }
}
