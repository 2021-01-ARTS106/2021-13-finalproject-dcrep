using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBurst : MonoBehaviour
{

    public ParticleSystem ps1, ps2, ps3, ps4;
    private int idx = 0;
    public void PlayBurst()
    {
        // Rotate
        switch(idx)
        {
            case 0:
                ps1.Play();
                break;
            case 1:
                ps2.Play();
                break;
            case 2:
                ps3.Play();
                break;
            default:
                ps4.Play();
                idx = -1;   // increment below resets to 0
                break;
        }
        idx++;
    }
}
