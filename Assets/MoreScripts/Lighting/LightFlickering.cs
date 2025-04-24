using System.Security.Cryptography;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    Light Light;
    public float Base = 100f;
    public float Max = 85f;
    public float f = 4f;
    bool On = true;
    float Delay;
    float Timer;
    float T;
    [SerializeField] bool RandomFlicker;
    [SerializeField] bool ShortFlickerOff;
    void Start()
    {
        Light = GetComponent<Light>();
    }

    void Update()
    {
        if (RandomFlicker)
        {
            Flickering();
        }
        else if (ShortFlickerOff)
        {
            ShortFlicker();
        }
    }

    void Flickering()
    {
        Timer += Time.deltaTime;
        if (Timer > Delay)
        {
            On = !On;
            if (On)
            {
                Light.intensity = Base;
                Delay = Random.Range(0, 1);
            }
            else
            {
                Light.intensity = Random.Range(25, Max);
                Delay = Random.Range(0, 0.4f);
            }
            Timer = 0;
        }
    }

    void ShortFlicker()
    {
        T += Time.deltaTime;
        if (T < f)
        {
            Flickering();
        }
        else if (T > f)
        {
            Light.intensity = 0;
        }
    }
}
