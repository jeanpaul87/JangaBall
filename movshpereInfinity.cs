using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movshpereInfinity : MonoBehaviour
{
    protected Joystick joystick;
    private Rigidbody rb;
    public float speed;
public GameObject endButton;
    public GameObject spawnPointt;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody>();
        endButton.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = joystick.Horizontal + Input.GetAxis("Horizontal");
        float moveV = joystick.Vertical + Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(moveH * speed, 0.0f, 0.0f);

        rb.AddForce(mov);

        //    var rigidbody = GetComponent<Rigidbody>();
        //    rigidbody.velocity = new Vector3(joystick.Horizontal + Input.GetAxis("Horizontal") * 105f * Time.deltaTime, rigidbody.velocity.y, (joystick.Vertical + Input.GetAxis("Vertical") * 105f * Time.deltaTime));

    }
void Update(){
    if(eventyInfinit.isOnPlatform == -1){
        gameObject.transform.position = spawnPointt.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            endButton.SetActive(true);
    }
}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "mout" ) 
        {
            soundManager.PlaySound("DeadSound");

            gameObject.transform.position = spawnPointt.transform.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            endButton.SetActive(true);
        }
    }
 
}
