using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForMove : MonoBehaviour
{
    public bool cant;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Stone"))
        {
            cant = true;
        }
    }
     private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Stone"))
        {
            cant = false;
        }
    }
}
