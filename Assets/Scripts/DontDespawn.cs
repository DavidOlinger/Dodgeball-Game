using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDespawn : MonoBehaviour
{
    private static DontDespawn instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
