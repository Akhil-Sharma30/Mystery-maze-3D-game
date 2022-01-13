using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameChecker : MonoBehaviour
{
    bool gamended = false;
    public float value = 2f;

    public GameObject completegameUI;

   
    public void completeGame()
    {
        completegameUI.SetActive(true);
    }

  
    
}

