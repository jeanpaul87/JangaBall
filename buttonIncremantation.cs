using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonIncremantation : MonoBehaviour

{   public Color newColor;
    public Material matOfObject;
    public static bool isTouchingTheSecondButton;



    private void Start()
    {
        isTouchingTheSecondButton = false;
        matOfObject.color = Color.white;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("box"))
        {

            isTouchingTheSecondButton = true;
            touchingButton.total++;
         //   matOfObject.color = newColor;
            other.gameObject.GetComponent<Renderer>().material.color = newColor;


        }
        


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("box"))
        {
            isTouchingTheSecondButton = false;
            touchingButton.total--;
            // matOfObject.color = Color.white;
            other.gameObject.GetComponent<Renderer>().material.color = Color.white;


        }
        
    }
}
