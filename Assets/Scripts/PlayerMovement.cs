using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //other classes can know about it (Public class)
    //name of class   (Playermovement)

    // Use this for initialization, something we only want to happen once
    void Start()//the stuff that is inside of the start engine, it's called by the unity engine once, at the start. 
    {
        //transform.position = new Vector3(-9, -6, 0);
       // transform.Translate(10, 0, 0);
        //Debug.Log("Hello, this code is inside of start.");
        //log is a function, which means he needs an open and close parentheses. it logs a message to a unity console
    }

    // Update is called once per frame, this is the code that causes movement, this is frame rate.
    void Update()
    {

        transform.Translate(0.1f, 0, 0);
        //Debug.Log("This is called from Update!!!");
    }
}
        //vector3 is something called a strut, kind of like a class 