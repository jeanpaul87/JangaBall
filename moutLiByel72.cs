using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moutLiByel72 : MonoBehaviour
{
    public int movSphere;
    private void OnTriggerStay(Collider other)
    {
     //   Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Player")
        {
           // Debug.Log("haa");
            transform.LookAt(other.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, other.gameObject.transform.position, movSphere * Time.deltaTime);
            
        }
    }
}
