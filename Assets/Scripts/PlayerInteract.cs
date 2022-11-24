using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public GameObject menuPanel;
    public GameObject messageText;

    public void OnTriggerEnter2d(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            menuPanel.SetActive(true);
            currentInterObj = other.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject"))
        {
            if (other.gameObject == currentInterObj) {
                menuPanel.SetActive(false);
                currentInterObj = null;
                    }
                }
        }
}