using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuggetsScript2 : MonoBehaviour
{

    void Start()
    { 
        gameObject.SetActive(true);

    }
    private void Update()
    {
        
        gameObject.transform.Rotate(new Vector3(1f, 1f, 5f));

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        soundManager.PlaySound("NuggetsSound");

        gameObject.SetActive(false);
        nuggetsScript.nuggetsIncremantation++;
        int scoreTotal = PlayerPrefs.GetInt("NuggetsCurrency") + 1;
        PlayerPrefs.SetInt("NuggetsCurrency",scoreTotal);
        //Debug.Log("LEZIMTZID");
        
    }
}
