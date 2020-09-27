using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showText : MonoBehaviour
{
    public GameObject text;
   // public GameObject pannel;
        void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.gameObject.SetActive(true);
           // pannel.SetActive(true);

        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            text.gameObject.SetActive(false);
           // pannel.SetActive(false);

        }

    }
}
