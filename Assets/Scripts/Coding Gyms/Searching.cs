using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Searching : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Vector2 start;
    public Vector2 end;
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        start = transform.position;
        end.x = Random.Range(-9, 9);
        end.y = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1)
        {
            t = 0;
            start = end;
            end.x = Random.Range(-9, 9);
            end.y = Random.Range(-5, 5);
            PickARandomColor();
        }
        transform.position = Vector2.Lerp(start, end, t);
    }
    void PickARandomColor()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
