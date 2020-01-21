using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public GameObject newPosCheckPoint;
    public Color newColor;
    public Material matOfObject;
 
    void Start()
    {
        matOfObject.color = Color.gray;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            soundManager.PlaySound("CheckpointSound");

            newPosCheckPoint.transform.position = gameObject.transform.position;
            gameObject.GetComponent<Renderer>().material.color = newColor;

        }
    }


}
