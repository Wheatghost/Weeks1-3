using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public Sprite[] fish;
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
           PickARandomSprite();
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

    }
    void PickARandomColor()
    {
        col = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //get a random number 0-2 and use that to choose a sprite 
        randomNumber = Random.Range(0, fish.Length);
        spriteRenderer.sprite = fish[randomNumber];
    }
}
