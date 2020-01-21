using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip hitEnemy, hitFinish, hitNuggets, hitCheckPoint;
    static AudioSource audioSrc;


    // Start is called before the first frame update
    void Start()
    {
        hitEnemy      = Resources.Load<AudioClip>("DeadSound");
      //  hitFinish     = Resources.Load<AudioClip>("FinishSound");
        hitNuggets    = Resources.Load<AudioClip>("NuggetsSound");
        hitCheckPoint = Resources.Load<AudioClip>("CheckpointSound");

        audioSrc = gameObject.GetComponent<AudioSource>();    
    }

     public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "DeadSound":
                audioSrc.PlayOneShot(hitEnemy);
                break;
         /*   case "FinishSound":
                audioSrc.PlayOneShot(hitFinish);
                break;*/
            case "NuggetsSound":
                audioSrc.PlayOneShot(hitNuggets);
                break;
            case "CheckpointSound":
                audioSrc.PlayOneShot(hitCheckPoint);
                break;
        }
    }
}
