using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCheckOrange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UiObjectRight;
    public GameObject UiObjectWrong;
    public GameObject Trigger;

    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(UiObjectRight, 2.0f));



        if (other.tag == "OrangeCube")
        {
            UiObjectRight.SetActive(true);
        }
        else
        {
            UiObjectRight.SetActive(false);
            UiObjectWrong.SetActive(true);
        }
    }




    IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);
    }
}
