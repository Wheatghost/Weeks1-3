using Unity.VisualScripting;
using UnityEngine;

public class FishLeap : MonoBehaviour
{
    //positions for the fish script
    public Transform fishStart;
    public Transform fishEnd;
    public float t;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //have a fish swim across the scene
        t += Time.deltaTime/30;
        if (t > 1)
        {
            t = 0;
        }
        transform.position = Vector2.Lerp(fishStart.position, fishEnd.position, curve.Evaluate(t));
    }
}
