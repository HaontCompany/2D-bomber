using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class StoneMap : MonoBehaviour
{
    [SerializeField] bool can;
    private int nowblunk;
    Vector3 vector2;
    private Transform[] Stones;
    private int col;
    private float x, y, z;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Application.isEditor && can)
        {
            ResetStone();
            can = false;
        }
    }
    private void ResetStone()
    {
        Transform tran = transform;
        nowblunk = 0;
        Stones = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            if (tran.GetChild(i).tag == "Stone")
            {
                Stones[nowblunk] = tran.GetChild(i).gameObject.transform;
                nowblunk++;
            }
        }
        StonePosition();
    }
    private void StonePosition()
    {
        x = 0;
        y = 0;
        z = 0;
        Vector3Reset();
        foreach (var stone in Stones)
        {
            stone.transform.position = vector2;
            vector2.x += 1.55f;
            col++;
            if (col == 8)
            {
                col = 0;
                x -= .2f;
                y -= 1.45f;
                z -= .1f;
                Vector3Reset();
            }
        }
    }
    private void Vector3Reset()
    {
        vector2.x = -5.3f + x;
        vector2.y = 2 + y;
        vector2.z = -.1f + z;
    }
}
