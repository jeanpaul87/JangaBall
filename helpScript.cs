using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpScript : MonoBehaviour
{

    public void HelpButton(GameObject pannel)
    {
        Debug.Log("lezim setActive tssir true   ");
        pannel.SetActive(true);
    }
}
