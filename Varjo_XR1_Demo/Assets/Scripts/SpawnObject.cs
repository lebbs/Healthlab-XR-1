using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VarjoExample
{
    public class SpawnObject : MonoBehaviour
    {

        Controller controller;
        bool buttonDown;
        public GameObject projectile;
        public Transform projectileOrigin;
        Rigidbody rb;
        GameObject bullet;
        float energy;
        public float energyFactor;

        // Start is called before the first frame update
        void Start()
        {
            controller = GetComponent<Controller>();
        }

        // Update is called once per frame
        void Update()
        {
            if (controller.Primary2DAxisClick)
            {
                if (!buttonDown)
                {
                    buttonDown = true;
                    bullet = Instantiate(projectile, projectileOrigin.transform.position, projectileOrigin.transform.rotation);
                    rb = bullet.GetComponent<Rigidbody>();
                    rb.isKinematic = true;
                    bullet.transform.parent = projectileOrigin;
                }
                else if (!controller.Primary2DAxisClick && buttonDown) // Button is released, projectile is released
                {
                    energy = energy + Time.deltaTime * energyFactor;
                    buttonDown = false;
                    rb.isKinematic = false;
                    bullet.transform.parent = null;
                    rb.AddForce(projectileOrigin.transform.position * energy, ForceMode.VelocityChange);
                    energy = 0f;
                }
            }

        }
    }
}
