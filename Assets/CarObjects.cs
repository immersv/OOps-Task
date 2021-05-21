using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObjects : MonoBehaviour
{
    // Start is called before the first frame update
    //create a car instance
   //public Car myBigCar;
   // public const float pi = 3.141f;//only for constant values
  public enum Direction {East,West,South,North }
    void Start()
    {
        Direction myDirection;

        myDirection= GetMyDirection(Direction.East);
        Debug.Log("My direction is " + myDirection);
       
    }

      Direction GetMyDirection(Direction direction)
    {
        Direction dir;
        dir = Direction.East;
        if (direction == Direction.East)
        {
            dir = Direction.North;
        }
        return dir;
    }
}
