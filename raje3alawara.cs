using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raje3alawara : MonoBehaviour
{
    [SerializeField] private Transform spawnPonit;
    [SerializeField] private GameObject objet;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log
               ("hahahahhah");

            objet.transform.position = spawnPonit.transform.position;
        }
    }
}
