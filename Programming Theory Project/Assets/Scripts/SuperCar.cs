using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCar : Car  // INHERITANCE 
{
    void Start()
    {
        carSpeed = 100f; //other end of encapsulation
        carTurnSpeed = 250f;
        printCarYear();
    }

    public override void printCarYear()  //POLYMORHPISM
    {
        Debug.Log("The car you are using is a Super Car!");
        base.printCarYear();
    }


}
