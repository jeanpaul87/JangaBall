using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationYaxis : MonoBehaviour
{
    public float rotationSpeed = 4f;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, rotationSpeed, 0f));
    }
}
