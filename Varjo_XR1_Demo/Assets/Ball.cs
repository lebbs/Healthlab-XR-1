using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public Rigidbody rigidbody;
    void Start()
    {
        //float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        //float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        //float sz = Random.Range(0, 2) == 0 ? -1 : 1;

        //GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, speed * sz);
    }

    private void OnCollisionEnter(Collision collision)
    {

        rigidbody.velocity = speed * (rigidbody.velocity.normalized);
    }
    }

