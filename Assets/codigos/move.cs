
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class move : MonoBehaviour
{
    public Rigidbody variavel;
   
   

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 1);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-4, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(4, 0, 0);
        }
        
    }
}
