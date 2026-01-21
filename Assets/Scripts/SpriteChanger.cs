using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> fish;
    public int randomNumber;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomColor();
        PickARandomSprite();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite");
            if (fish.Count > 0)
            {
                PickARandomSprite();
            }
        
           PickARandomColor();
        }

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the sprite
        if (spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: use the col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set the colour to white
            spriteRenderer.color = Color.white;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame == true && fish.Count>0)
        {
            fish.RemoveAt(0);
        }
    }
    void PickARandomColor()
    {
        col = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number 0-2 and use that to choose a sprite 
        randomNumber = Random.Range(0, fish.Count);
        spriteRenderer.sprite = fish[randomNumber];
    }
}
