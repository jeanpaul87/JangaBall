using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movSphere : MonoBehaviour
{

    protected Joystick joystick;
    private Rigidbody rb;
    public float speed;

    public Text levelName;
    public static int kilometraj;


    [SerializeField] private Transform spawnPonit ;
    [SerializeField] private GameObject endOfPartButton;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
        transform.position = spawnPonit.transform.position;
 
    }


    void FixedUpdate()
    {
        float moveH = joystick.Horizontal + Input.GetAxis("Horizontal");
        float moveV = joystick.Vertical + Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveH * Time.deltaTime * speed * 100f, 0.0f, moveV * Time.deltaTime * speed * 100f);

        rb.AddForce(mov);

       //useless// Debug.Log(mov.magnitude);
        int speedOfShpehere =(int) (rb.velocity.magnitude);
        kilometraj = speedOfShpehere;
      //  Debug.Log(a);  


        //    var rigidbody = GetComponent<Rigidbody>();
        //    rigidbody.velocity = new Vector3(joystick.Horizontal + Input.GetAxis("Horizontal") * 105f * Time.deltaTime, rigidbody.velocity.y, (joystick.Vertical + Input.GetAxis("Vertical") * 105f * Time.deltaTime));

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "mout")
        {
            soundManager.PlaySound("DeadSound");

            gameObject.transform.position = spawnPonit.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        if (other.gameObject.tag == "Finish")
        {
            //soundManager.PlaySound("FinishSound");
            
            Scene sceneLoaded = SceneManager.GetActiveScene();
            SceneManager.LoadScene(sceneLoaded.buildIndex + 1);



            if (SceneManager.GetActiveScene().buildIndex >= unlockLevels.level)
            {
                PlayerPrefs.SetInt("arrivedMap", (SceneManager.GetActiveScene().buildIndex + 1));
                unlockLevels.level = PlayerPrefs.GetInt("arrivedMap");
            }
        }
        if (other.gameObject.tag == "FinishEasy")
        {
            //soundManager.PlaySound("FinishSound");

            Scene sceneLoaded = SceneManager.GetActiveScene();
            SceneManager.LoadScene(sceneLoaded.buildIndex + 1);



            if (SceneManager.GetActiveScene().buildIndex >= unlockLevels.levelEasy)
            {
                PlayerPrefs.SetInt("arrivedMapEasy", (SceneManager.GetActiveScene().buildIndex + 1 - 15));
              //  Debug.Log(SceneManager.GetActiveScene().buildIndex + 1 - 14);
                unlockLevels.levelEasy = PlayerPrefs.GetInt("arrivedMapEasy");
            }
        }

        if (other.gameObject.tag == "showLevelName")
        {   
            

            levelName.text = SceneManager.GetActiveScene().name;
            
        }
        if (other.gameObject.tag == "endOfPart")
        {   
            

            endOfPartButton.SetActive(true);
            
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "showLevelName")
        {  
            levelName.text = "  ";
        }
    }
}
