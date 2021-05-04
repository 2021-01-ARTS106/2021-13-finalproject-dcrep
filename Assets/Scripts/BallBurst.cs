using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBurst : MonoBehaviour
{

    public ParticleSystem ps;
    public void PlayBurst()
    {
        ps.Play();
    }
}
