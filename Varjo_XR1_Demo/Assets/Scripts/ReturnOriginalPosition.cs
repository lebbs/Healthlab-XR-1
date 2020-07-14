using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOriginalPosition : MonoBehaviour
{

    Vector3 originalPosition;
    Rigidbody rigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if(gameObject.transform.position.y <= -10)
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Target")
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
        }
    }
}
