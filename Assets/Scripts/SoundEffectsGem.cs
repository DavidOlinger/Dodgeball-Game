using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsGem : MonoBehaviour
{
    public AudioSource Gem;

    void Start()
    {
        Gem = GetComponent<AudioSource>();
    }

    public void gemSound()
    {
        Gem.Play();
    }

}
