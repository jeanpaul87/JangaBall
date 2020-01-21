using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrols : MonoBehaviour
{
    public Transform[] partols;
    public float movSpeed;
    private int currentPoint;


    // Start is called before the first frame update
    void Start()
    {
       
        transform.position = partols[0].transform.position;
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if( transform.position == partols[currentPoint].position) { currentPoint++; }
       if(currentPoint >= partols.Length) { currentPoint = 0; }
        transform.position = Vector3.MoveTowards(transform.position, partols[currentPoint].position, movSpeed*Time.deltaTime);
    }
}
