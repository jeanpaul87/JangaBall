using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuggetsScript : MonoBehaviour

{    public static int nuggetsIncremantation;
     public GameObject finishh;

     public int nMaxNuggests;

    public static int N_MAX;


    
    void Start()
    {
       
        nuggetsIncremantation = 0;
        N_MAX = nMaxNuggests;
        finishh.SetActive(false);
       // Debug.Log("STARTING");
    }

    
    void Update()
    {
      //  Debug.Log("nugetsInc" + nuggetsIncremantation);
     //   Debug.Log("nMax" + nMaxNuggests);
     //   Debug.Log("NMAX "+N_MAX );
        if (nuggetsIncremantation == nMaxNuggests)
        {
           // Debug.Log("DDDDDDDDDD");
            finishh.SetActive(true);
            nuggetsScore.score.text = "You just collected all the required nuggets," +
                             " you may now proceed to the next level.";
            nuggetsIncremantation = 0;
        }

    }

}
