using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
   // public GameObject levelButtonPrefab;
   // public GameObject levelButtonContainer;


   

    private Transform cameraTransform;
    private Transform cameraDesiredLookAt;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        
       // Sprite[] thumbnails = Resources.LoadAll<Sprite>("Levels");
    }
    private void Update()
    {
        if (cameraDesiredLookAt != null)
        {
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, cameraDesiredLookAt.rotation, 3 * Time.deltaTime);
        }
                }

    public void LookAtMenu(Transform menuTransform)
    {
      //  Camera.main.transform.LookAt(menuTransform.position);
        cameraDesiredLookAt = menuTransform;
    }

    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1f;

    }
    public void Pause(GameObject pannel)
    {
        pannel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume(GameObject pannel)
    {
        pannel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void OpenPannel(GameObject pannel)
    {
        pannel.SetActive(true);
    }
    public void ClosePannel ( GameObject pannel)
    {
        pannel.SetActive(false);
    }

    
}

