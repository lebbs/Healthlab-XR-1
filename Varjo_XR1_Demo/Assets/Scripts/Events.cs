using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class Events : MonoBehaviour
{

    public GameObject Targets;
    public GameObject Throwables;
 public void OnCustomButtonPress()
    {
        //Targets.SetActive(true);

        if(Targets.activeSelf == false || Throwables.activeSelf == false)
        {
            Targets.SetActive(true);
            Throwables.SetActive(true);
        }
        else
        {
            Targets.SetActive(false);
            Throwables.SetActive(false);
        }

        Debug.Log("Toimii");
    }
    
}
