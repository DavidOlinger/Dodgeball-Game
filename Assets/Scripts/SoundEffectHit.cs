using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectHit : MonoBehaviour
{

    public AudioSource Hit;

    void Start()
    {
        Hit = GetComponent<AudioSource>();
    }

    public void hitSound()
    {
        Hit.Play();
    }

 
}
