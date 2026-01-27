using NUnit;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class TideSwelling : MonoBehaviour
{
    //Makes the water swell with the tide and then recede
    public Vector3 tide;
    //time
    public float t;
    //tells the water to swell or recede
    public float swell = 1;
    //tells the code if it's making the bobber go up and down instead
    public float bobber;
    //gets the bobber to move along it's path with the water
    public Transform bobStart;
    public Transform bobEnd;
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //checks if the water is meant to be rising or falling
        if (swell == 1)
        {
            //works on a 15 second loop
            t += Time.deltaTime / 15;
            //I only want to scale the bobber
            if (bobber == 0)
            {
                tide.y = 0.08431612f + t / 10;
            }
        }
        //same as the if statement above, just inverted t0 receding/lowering
        else if (swell == -1)
        {
            t -= Time.deltaTime / 15;
            if (bobber == 0)
            {
                tide.y = 0.08431612f + t / 10;
            }
        }
        //if 15 seconds have passed, switch the tide to its opposite
        if (t > 1 || t < 0)
        {
            swell *= -1;
        }
        transform.localScale = tide;
        if (bobber == 1)
        {
            transform.position = Vector2.Lerp(bobStart.position, bobEnd.position, curve.Evaluate(t));
        }
    }
}

