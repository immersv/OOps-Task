using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This isEmpty Car class
[System.Serializable]
public class Car 
{
    //attributes or properties
   public string carName;
    public int makeYear;
    public float maxSpeed;
  
    //constructor
    public Car()
    {
        Debug.Log("Car Default Constructor called");
    }
    public Car(float maximumSpeed)
    {
        maxSpeed = maximumSpeed;
        Debug.Log("second consructor called");
        Debug.Log("Maximum speed=" + maxSpeed);
    }
    public Car(int makeYear, string carName)
    {
        this.makeYear = makeYear;
        this.carName = carName;
    }
    //behaviour or methods
    public void Drive()
    {
        Debug.Log("This drive car name is "+carName);
    }
    public void ApplyBrake()
    {
        Debug.Log("This is to apply car brake");
    }

    public float Speed()
    {
        Debug.Log("The max speedof the car: " + maxSpeed);
        return maxSpeed;
    }
    public void PrintCarDetails()
    {
        Debug.Log("Tha car name is" + carName);
        Debug.Log("The carmake year is" + makeYear);
        Debug.Log("The car max speed is " + maxSpeed);
        
    }
   
}
