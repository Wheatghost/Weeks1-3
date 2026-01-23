using UnityEngine;
using UnityEngine.InputSystem;

public class MovingTheSun : MonoBehaviour
{
    public Vector3 pos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = pos;
    }
}
