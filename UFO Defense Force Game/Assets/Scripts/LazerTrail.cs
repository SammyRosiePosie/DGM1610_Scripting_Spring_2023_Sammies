using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerTrail : MonoBehaviour
{
    public ParticleSystem lazerTrailParticles;

    void LazerParticles()
    {
        Instantiate(lazerTrailParticles, transform.position, transform.rotation);
    }

}
