using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButtonScriptInfint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pannel; 
      public void RestartInfinit(){
        pannel.SetActive(false);
        Debug.Log("lezimtssirFlase");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
