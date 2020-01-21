using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nuggetsScore : MonoBehaviour
{
   
    public static Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    { if (nuggetsScript.nuggetsIncremantation != 0)
        {
            score.text = nuggetsScript.nuggetsIncremantation + " / " + nuggetsScript.N_MAX + " Nuggets";
         /*   if (nuggetsScript.nuggetsIncremantation == nuggetsScript.N_MAX)
            {
                score.text = "You just collected all the required nuggets," +
                             " you may now proceed to the next level.";
                nuggetsScript.nuggetsIncremantation = 0;
            }*/
        }
        
    }
}
