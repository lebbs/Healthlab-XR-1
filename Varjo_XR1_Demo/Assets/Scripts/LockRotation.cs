using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{

    Rigidbody rigidbody;
    // Start is called before the first frame update
    
    private void FixedUpdate()
    {
      if(rigidbody.velocity != Vector3.zero)
        {
            rigidbody.rotation = Quaternion.LookRotation(rigidbody.velocity);
        }
    }
}
