using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArrow : MonoBehaviour
{
    public Sprite pressed; // Drag your first sprite here
    public Sprite notPressed; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = notPressed; // set the sprite to sprite1
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // If the space bar is pushed down
        {
            ChangeSpritePress(); // call method to change sprite
        }
        else
        {
            ChangeSpriteNotPress();
        }
    }

    void ChangeSpritePress()
    {
        spriteRenderer.sprite = pressed; // otherwise change it back to sprite1
    }

    void ChangeSpriteNotPress()
    {
        spriteRenderer.sprite = notPressed; // otherwise change it back to sprite1
    }


}
