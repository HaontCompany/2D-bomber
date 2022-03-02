using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    public Transform persT;
    public CheckForMove[] checkForMoves;
    public Vector3 posVec;
    public bool[] vector4 = new bool[4];
    void Start()
    {
        persT = transform;
        posVec = persT.position;
        checkForMoves = new CheckForMove[persT.childCount];
        for (int i = 0; i < persT.childCount; i++)
        {
            checkForMoves[i] = persT.GetChild(i).GetComponent<CheckForMove>();
        }
    }
}
