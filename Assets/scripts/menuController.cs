using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    [SerializeField] private string newGameLevel = SceneManager.GetActiveScene().name;

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

   
   
}
