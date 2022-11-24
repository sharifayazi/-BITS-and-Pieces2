using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameObject replayButton;

    public void Replay()
    {
        if (Input.GetKey("Replay"))
            replayButton.SetActive(true);
            ResetTheGame();
    }
                
     public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

