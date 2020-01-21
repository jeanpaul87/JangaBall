using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform lookAt;

    private Vector3 offset;

    private float distance= 5.0f;
    private float yOffset = 3.5f;

    private void Start()
    {
        offset = new Vector3(0, yOffset, -1f * distance);
    }
    private void Update()
    {
        transform.position = lookAt.position + offset;

    }
 
}
