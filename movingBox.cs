using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingBox : MonoBehaviour
{
    // Start is called before the first frame update
   // public static int longeurDistance = 50 ;
  //  public static int hauteurDistance = -5;
    
 //  public static int maxLongeurDistance = 48;
 //  public static int  maxhauteurDistance = -6;
    private int maxZDistance = 2;
    //public GameObject barra;
  //  public GameObject player;

    


    void Start()
    {
       // maxZDistance = Random.Range(0, 3);
       // longeurDistance = Random.Range(20, maxLongeurDistance);
      //  hauteurDistance = Random.Range(-3, maxhauteurDistance);
       
    }

    // Update is called once per frame
    // void Update()
    // {
    //     // Debug.Log(eventyInfinit.isOnPlatform);
       
    //     // if (eventyInfinit.isOnPlatform == 0 ){
    //     //     eventyInfinit.blockCounter = 5; //rest block Counter
    //     //    // longeurDistance = 50;
    //     //    // hauteurDistance = -5;
    //     //     eventyInfinit.isOnPlatform =-1;
    //     //  // Time.timeScale = 0f; // to pause the game
    //     //    // Scene sceneLoaded = SceneManager.GetActiveScene();
    //     //    //SceneManager.LoadScene(sceneLoaded.buildIndex);
    //     // }
    // }
        
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //  Debug.Log("isOnPlatform");
            eventyInfinit.isOnPlatform++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            eventyInfinit.blockCounter++;

            // Debug.Log("isNotOnPlatform");
            maxZDistance = Random.Range(-3, 4);
            transform.position  += new Vector3(maxZDistance, -25 , 200);
                                                         
            
          //  longeurDistance = Random.Range(45, maxLongeurDistance);
         //   hauteurDistance = Random.Range(maxhauteurDistance, -4);
            // Debug.Log(transform.position);
            eventyInfinit.isOnPlatform--;
           
            
        }
    }


}
