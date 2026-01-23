using UnityEngine;

public class Teleport : MonoBehaviour
{
    //Time
    public float t;
    //Position
    Vector3 pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if it's been 3 seconds and when that happens randomizes the position
        t += Time.deltaTime;
        if (t > 3)
        {
            t = 0;
            pos.x = Random.Range(-9, 9);
            pos.y = Random.Range(-5, 5);
        }

        //new position
        transform.position = pos;

        
    }
}
