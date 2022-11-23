using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSlotMenu : MonoBehaviour
{
    private SaveSlot[] saveSlot;

    private void Awake()
    {
        saveSlot = this.GetComponentsInChildren<SaveSlot>();
    }

    public void OnSaveSlotClicked(SaveSlot saveSlot)
    {
        DataPersistenceManager.Instance.ChangeSelectedProfileID(saveSlot.GetProfileID());

        DataPersistenceManager.Instance.SaveGame();
              
    }

    private void Start()
    {
        ActivateMenu();
    }
  

    public void ActivateMenu()
    {
        
        Dictionary<string, GameData> profilesGameData = DataPersistenceManager.Instance.GetAllProfilesGameData();

        foreach (SaveSlot saveSlot in saveSlot)
        {
            GameData profileData = null;
            profilesGameData.TryGetValue(saveSlot.GetProfileID(), out profileData);
            saveSlot.SetData(profileData);

         
        }
    }
}
