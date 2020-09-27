using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nuggetsScoreInfinity : MonoBehaviour
{

    public  Text score;
    public  Text distance;
    public  Text kilokilometraj;

public static int distanceStatic;
    public Transform playerForDistance;
    public Text highScoreDistanceText;
    private int saveHighScoreDistance;
    private int saveHighScoreNuggets;

    void Start()
    {
     //  score = GetComponent<Text>();
     //  distance = GetComponent<Text>();
    //REST SCORE
     //PlayerPrefs.SetInt("highScoreDistance",0);
    // PlayerPrefs.SetInt("highScoreNuggets",0);
     //Debug.Log("SETINTLEZIMTEMSHE");
     saveHighScoreDistance = PlayerPrefs.GetInt("highScoreDistance");
     saveHighScoreNuggets = PlayerPrefs.GetInt("highScoreNuggets");

     highScoreDistanceText.text = "HighScore : "+ saveHighScoreDistance.ToString() + " M";
    }

    // Update is called once per frame
    void Update()
    {
           // if (nuggetsScript.nuggetsIncremantation != 0)
        if (nuggetsScript.nuggetsIncremantation < 3120)
        {   

            float distanceMeter = playerForDistance.position.z;
            float numberNugg = nuggetsScript.nuggetsIncremantation;
            distanceStatic = (int)distanceMeter;

            score.text = nuggetsScript.nuggetsIncremantation + " Nuggets";
            distance.text = ((int)distanceMeter).ToString() + " M";
            kilokilometraj.text = movSphere.kilometraj + "km/s";
       
            if (saveHighScoreDistance < (int)distanceMeter){
                PlayerPrefs.SetInt("highScoreDistance",(int)distanceMeter);
                highScoreDistanceText.text = "HighScore : "+((int)distanceMeter).ToString() + " M";
            }

            if (saveHighScoreNuggets < (int)numberNugg){
                PlayerPrefs.SetInt("highScoreNuggets",(int)distanceMeter);

            }
        }

    }
}
