using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShowControls : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene(5);
    }
}
