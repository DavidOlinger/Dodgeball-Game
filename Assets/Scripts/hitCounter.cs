using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCounter : MonoBehaviour
{
    public Score logic;
    
    public int hitCount = 0;

    private bool canHit = true;
    public float hitCooldown = 0.33f;

    public SoundEffectHit sound;


    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Score>();
        sound = GameObject.FindGameObjectWithTag("hitSound").GetComponent<SoundEffectHit>();

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball" && canHit)
        {
            hitCount++;
            logic.addCount();
            sound.hitSound();
        }

        canHit = false;

        Invoke("Reset", hitCooldown);
    }
    
    private void Reset()
    {
        canHit = true;
    }
}
