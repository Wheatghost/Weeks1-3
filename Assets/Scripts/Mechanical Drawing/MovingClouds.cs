using UnityEngine;

public class MovingClouds : MonoBehaviour
{
    //giving the clouds a start and end position
    public Vector2 start;
    public Vector2 end;
    //time variable that allows them to loop
    public float t;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime/30;
        
        transform.position = Vector2.Lerp(start, end, t);
        if (t > 1)
        {
            t = 0;
        }
    }
    
}