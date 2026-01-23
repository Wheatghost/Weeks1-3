using UnityEngine;
using UnityEngine.InputSystem;

public class MovingTheSun : MonoBehaviour
{
    //Vector to control the sun's position
    public Vector2 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //making position = the mouse's position
        pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //changing the y coordinate to a fixed position so that the sun doesn't follow the mouse exactly
        pos.y = 3f;
        //sending the sun to the current mouse position 
        transform.position = pos;
        
    }
}
