using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]

public class DestroyOnParticleSystemDeath : MonoBehaviour
{
    private ParticleSystem particles;

    // Start is called before the first frame update
    void Awake()
    {
        particles = GetComponent<ParticleSystem>();

        InvokeRepeating("CheckParticleSystem", 0.1f, 0.1f);
    }

    // Update is called once per frame
    private void CheckParticleSystem()
    {
        if (!particles.IsAlive())
        {
            Destroy(this.gameObject);
        }
    }
}
