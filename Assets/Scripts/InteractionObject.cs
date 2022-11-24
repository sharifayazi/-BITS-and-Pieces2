using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject messageText;
    
    public void DoInteraction()
    {
        menuPanel.SetActive(false);
    }
 }

