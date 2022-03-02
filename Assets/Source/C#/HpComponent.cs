using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpComponent : MonoBehaviour
{
    private void hpLose()
    {
        gameObject.SetActive(false);
    }
     private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Fire"))
        {
            hpLose();
        }
    }
}
