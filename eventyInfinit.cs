using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventyInfinit : MonoBehaviour
{
    public static int isOnPlatform;
    public static int blockCounter = 0;
    // public GameObject mout;
    //public GameObject positionn;
    public GameObject nuggetsPrefab;
    public GameObject[] obstacles;
    public GameObject[] platform;

    // Start is called before the first frame update
    void Start()
    {
        isOnPlatform = 0;
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(blockCounter);
        if (blockCounter == 3)
        {
            Instantiate(nuggetsPrefab, platform[Random.Range(0, 5)].transform.position + new Vector3(Random.Range(-2,3), 1, 10) , Quaternion.identity);
            blockCounter++;
        }
        if (blockCounter == 5)
        {
            Instantiate(obstacles[Random.Range(0,2)],
                platform[Random.Range(0, 5)]
                .transform.position + new Vector3(Random.Range(-2, 3), 1, 10), 
                Quaternion.identity);

            blockCounter = 0;
        }
        
    }
}
