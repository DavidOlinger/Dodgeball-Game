using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int currentScene = 1;
    public static Score instance;
    
  
    public int hitCounter;
    public Text HitText;  

    public int gemCounter;
    public Text GemText;
    public int gemTarget;




    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;

        }
        else
        {
            Destroy(gameObject);  
        }
    }


    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 0)
        {
            hitCounter = 0;
            HitText.text = hitCounter.ToString();

            currentScene = 1;
            gemTarget = 20;
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }






    public void addCount()
    {
        hitCounter++;
        HitText.text = hitCounter.ToString();
    }

    public void gemGet()
    {
        gemCounter++;
        GemText.text = gemCounter.ToString();

        if(gemCounter >= gemTarget)
        {
            currentScene++;
            SceneManager.LoadScene(currentScene);
            gemCounter = 0;
            GemText.text = gemCounter.ToString();
            gemTarget = gemTarget + 5;
        }
    }

    


}
