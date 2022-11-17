using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    [Header ("Sprite To Change")]
    public SpriteRenderer colour;

    [Header ("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    { 
        currentOption++;   
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }
        colour.sprite = options[currentOption];
    }

    public void PreviousOption()
    { 
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }

        colour.sprite = options[currentOption];
    }
}
