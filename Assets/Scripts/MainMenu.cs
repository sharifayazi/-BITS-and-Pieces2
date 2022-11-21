using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnNewGameClicked()
    {
        DataPersistenceManager.Instance.NewGame();             
               
    }
   
    public void OnLoadGameClicked()

    {
        Debug.Log("Load button clicked");
    }
}
