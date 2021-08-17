using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCar : Car
{
    void Start()
    {
        carSpeed = 50f;
        carTurnSpeed = 250f;
        printCarYear();
    }

    public override void printCarYear()
    {
        Debug.Log("The car you are using is a Super Car!");
        base.printCarYear();
    }


}
