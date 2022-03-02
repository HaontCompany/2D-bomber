using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTimer : MonoBehaviour
{
    [SerializeField] GameObject fireBoom;
    private float timbomb;
    void OnEnable()
    {
        timbomb = 1f;
    }
    void Update()
    {
        if (timbomb < 0)
        {
            fireBoom.transform.position = transform.position;
            fireBoom.SetActive(true);
            gameObject.SetActive(false);
        }
        else
            timbomb -= Time.deltaTime;
    }
}
