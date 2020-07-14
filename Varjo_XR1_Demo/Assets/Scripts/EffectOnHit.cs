using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectOnHit : MonoBehaviour
{

    public Collider targetCollider1;
    public Collider targetCollider2;
    public Collider targetCollider3;
    public Collider targetCollider4;
    public Collider targetCollider5;
    public Collider targetCollider6;
    public GameObject spawnObjectOnCollision;

    public bool colorSpawnedObject = true;

    public bool destroyOnTargetCollision = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == targetCollider1||
            collision.collider == targetCollider2||
            collision.collider == targetCollider3||
            collision.collider == targetCollider4||
            collision.collider == targetCollider5||
            collision.collider == targetCollider6)
       
        {
            ContactPoint contact = collision.contacts[0];
            RaycastHit hit;

            float backTrackLength = 1f;
            Ray ray = new Ray(contact.point - (-contact.normal * backTrackLength), -contact.normal);
            if (collision.collider.Raycast(ray, out hit, 2))
            {
                if (colorSpawnedObject)
                {
                    Renderer renderer = collision.gameObject.GetComponent<Renderer>();                   
                    GameObject spawned = GameObject.Instantiate(spawnObjectOnCollision);
                    spawned.transform.position = contact.point;
                    spawned.transform.forward = ray.direction;

                }
            }
            Debug.DrawRay(ray.origin, ray.direction, Color.cyan, 5, true);

            if (destroyOnTargetCollision)
                Destroy(this.gameObject);
        }
    }
}
