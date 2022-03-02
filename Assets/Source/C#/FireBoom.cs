using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoom : MonoBehaviour
{
    private float tim;
    void OnEnable()
    {
        tim = .3f;
    }
    void Update()
    {
        if (tim < 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            tim -= Time.deltaTime;
        }
    }
}
