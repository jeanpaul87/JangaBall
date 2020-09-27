using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveScore : MonoBehaviour
{
    [SerializeField] Text nugScoreShowText;
    // Start is called before the first frame update
    void Start()
    {  // REST SCORE
        //PlayerPrefs.SetInt("NuggetsCurrency",0);
    }

    // Update is called once per frame
    void Update()
    {   
        string scoreTotal = PlayerPrefs.GetInt("NuggetsCurrency", unlockLevels.nuggetsCurency).ToString();
        Debug.Log(scoreTotal);
        nugScoreShowText.text = "total nuggets eaten    "+ scoreTotal;
        Debug.Log(PlayerPrefs.GetInt("NuggetsCurrency", unlockLevels.nuggetsCurency).ToString());
    }
}
