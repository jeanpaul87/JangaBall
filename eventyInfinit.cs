using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class eventyInfinit : MonoBehaviour
{
    public static int isOnPlatform;
    public static int blockCounter = 0;
    // public GameObject mout;
    //public GameObject positionn;
    public GameObject nuggetsPrefab;
    public GameObject[] obstacles;
    public GameObject[] platform;

    public Text highScoreTextEnd;
    
    // Start is called before the first frame update
    void OnLevelWasLoaded()
    {   
        isOnPlatform = 0;
        Debug.Log("LEVEL LOADED");
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {  
      //  Debug.Log(blockCounter);
        
        if ( isOnPlatform == 0){
            highScoreTextEnd.text ="     in this round :\n"+
                                    "nuggets collected   :  " + nuggetsScript.nuggetsIncremantation + " Nuggets\n" +  
                                    "you rolled             :  " + nuggetsScoreInfinity.distanceStatic.ToString() + " Meters\n" +
                                    "highest speed         :  " + movSphere.kilometraj + "km/s";
            blockCounter = 5; //rest block Counter
            isOnPlatform =-1;
            
           Debug.Log(eventyInfinit.isOnPlatform);
            //Time.timeScale = 0f; // to pause the game

        }
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
