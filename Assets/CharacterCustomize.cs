using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomize : MonoBehaviour
{
    public int skinNumber;
    public Skins[] skins;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void LateUpdate()
    {
        SkinChoice();
    }

    void SkinChoice()
    {
        if (spriteRenderer.sprite.name.Contains("character_idle"))
        {
            string spriteName = spriteRenderer.sprite.name;
            spriteName = spriteName.Replace("character_idle_", "");
            int spriteNumber = int.Parse(spriteName);
            spriteRenderer.sprite = skins[skinNumber].sprites[spriteNumber];
        }
    }
}
[System.Serializable]
public struct Skins
{
    public Sprite[] sprites;
}