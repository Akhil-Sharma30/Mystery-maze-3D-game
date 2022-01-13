using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collison : MonoBehaviour
{
    public ThirdPersonMovement player;

    public GameObject sastaGta;

    bool gamended = false;
    public float value = 2f;

    public GameObject completegameUI;

    private void OnTriggerEnter()
    {
        Debug.Log("collison happened");
        player.enabled = false;
        sastaGta.SetActive(true);
        //restartUI();
    }



    public void endPhase()
    {
        Debug.Log("game over");
        if (gamended == false)
        {
            gamended = true;
            //restart();

        }
    }
    void restartUI()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
