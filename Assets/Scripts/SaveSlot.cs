 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveSlot : MonoBehaviour
{
    [Header("Profile")]

    [SerializeField] private string profileID = "";

    [Header("Content")]

    [SerializeField] private GameObject noData;

    [SerializeField] private GameObject hasData;

    public void SetData(GameData data)
    {
        if (data != null)
        {
            noData.SetActive(true);
            hasData.SetActive(false);
        }
        else
        {
            noData.SetActive(false);
            hasData.SetActive(true);
        }
    }

    public string GetProfileID()
    {
        return this.profileID;
    }

    
}
