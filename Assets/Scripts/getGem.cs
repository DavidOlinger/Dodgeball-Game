using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getGem : MonoBehaviour
{
    public Score logic;
    public gemSpawn spawn;

    public SoundEffectsGem sound;



    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Score>();
        spawn = GameObject.FindGameObjectWithTag("gemSpawn").GetComponent<gemSpawn>();
        sound = GameObject.FindGameObjectWithTag("gemSound").GetComponent<SoundEffectsGem>();


    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            logic.gemGet();
            sound.gemSound();

            spawn.SpawnCoin();
            Destroy(gameObject);
        }
    }


}
