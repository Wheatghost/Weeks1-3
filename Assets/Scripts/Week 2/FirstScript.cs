using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float hSpeed = 0.02f;
    float vSpeed = 0.02f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += hSpeed;
        newPos.y += vSpeed;

        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            hSpeed *= -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            vSpeed *= -1;
        }

    }
}
