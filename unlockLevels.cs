using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockLevels : MonoBehaviour
{


    public static int thelevel;

    public static int level = 1;
    public static int levelEasy = 1;

    public int maxLevelChallenging;
    public int maxLevelEasy;

    public GameObject[] levelUnlocked;
    public GameObject[] levelUnlockedEasy;
    
    
    void Start()
    {
        Time.timeScale = 1f;
       level = PlayerPrefs.GetInt("arrivedMap", level);
       levelEasy = PlayerPrefs.GetInt("arrivedMapEasy", levelEasy);
       // Debug.Log(level);

        Debug.Log(maxLevelEasy);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(levelEasy);
            for (int i = 0; i < maxLevelChallenging; i++)
            {
                if (i < level)
                {
                    //  Debug.Log(i);
                    levelUnlocked[i].SetActive(true);
                }
                else
                {
                    levelUnlocked[i].SetActive(false);
                }
            }
            for (int i = 0; i < maxLevelEasy; i++)
            {
                if (i < levelEasy)
                {
                    //  Debug.Log(i);
                    levelUnlockedEasy[i].SetActive(true);
                }
                else
                {
                    levelUnlockedEasy[i].SetActive(false);
                }
            }
        
    }

   /* public static void NextLevel()
    {
        Debug.Log("next LEV checking levell == ne_level.theLevel");
        Debug.Log("level =");
        Debug.Log(level);
        Debug.Log("ne_level.thelevel =");
        Debug.Log(Ne_Level.thelevel);
        if ( level == Ne_Level.thelevel)
        {
            Debug.Log("LEZIM TZID 1 LEVEL");
            level += 1;
            Ne_Level.the_level(level);
        //    PlayerPrefs.SetInt("Level", level);
        }
    }*/

    public void Reset()
    {
        level = 1;
      // PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetInt("arrivedMap", 1);
        levelEasy = 1;
        PlayerPrefs.SetInt("arrivedMapEasy", 1);
    }
}
