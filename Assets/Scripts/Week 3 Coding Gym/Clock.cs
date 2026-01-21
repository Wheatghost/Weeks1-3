using UnityEngine;

public class Clock : MonoBehaviour
{
    public float tempo;
    public float ts;
    public float tm;
    public float th;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //adds a second every second
        ts += Time.deltaTime;
        if (ts >= 1)
        {
            if (tempo == 0)
            {
                Vector3 tick = transform.eulerAngles;
                tick.z -= 6;
                transform.eulerAngles = tick;
            }
            tm++;
            ts = 0;
           

            if (tm == 60)
            {
                if (tempo == 1)
                {
                    Vector3 tick = transform.eulerAngles;
                    tick.z -= 6;
                    transform.eulerAngles = tick;
                }
                tm = 0;
                th++;
            }

            if (th == 60)
            {
                if (tempo == 2)
                {
                    Vector3 tick = transform.eulerAngles;
                    tick.z -= 6;
                    transform.eulerAngles = tick;
                }
                th = 0;
            }

        }
    }
}
