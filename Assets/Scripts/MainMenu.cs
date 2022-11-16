using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnNewGameClicked()
    {
        DataPersistenceManager.Instance.NewGame();

        SceneManager.LoadSceneAsync("Sample Scene");
    }
   
    public void OnLoadGameClicked()
    {
        Debug.Log("Load button clicked");
    }
}
