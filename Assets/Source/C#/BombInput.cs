using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInput : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] Transform pigT;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BombSet();
        }
    }
    public void BombSet()
    {
        if (!bomb.activeSelf)
        {
            Vector3 pos = pigT.position;
            bomb.transform.position = new Vector3(pos.x, pos.y, -5);
            bomb.SetActive(true);
        }
    }
}
