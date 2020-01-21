using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchingButton : MonoBehaviour
{
    public Color newColor;
    public Material matOfObject;

    public GameObject finishh;
    public int nOfAllButtonsAvailableOnTheMap;
   
    public static int total;

    private bool isTouchingTheFirstButton;

    // Start is called before the first frame update
    private void Start()
    {
        isTouchingTheFirstButton = false;
           total = 0;
        matOfObject.color = Color.white;
        finishh.gameObject.SetActive(false);
    }

   
    // Update is called once per frame
    void Update()
    {
        Debug.Log(total);
        if (total == nOfAllButtonsAvailableOnTheMap && isTouchingTheFirstButton == true && buttonIncremantation.isTouchingTheSecondButton == true)
        {
            Debug.Log("LELZIM TEMSHE!!!");  
            finishh.SetActive(true);
        }
    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("box")) 
        {
            isTouchingTheFirstButton = true;
            Debug.Log("HUUU");
            total++;
            other.gameObject.GetComponent<Renderer>().material.color = newColor;
           // matOfObject.color = newColor;
         }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("box"))
        {
            isTouchingTheFirstButton = false;
            Debug.Log("HAAA");
            total--;
            // matOfObject.color = Color.white;
            other.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
