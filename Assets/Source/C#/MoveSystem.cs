using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    [SerializeField] MoveComponent[] moveComponents;
    private float timwait;
    private void Awake()
    {
        moveComponents = GameObject.FindObjectsOfType<MoveComponent>();
    }
    void Update()
    {
        if (timwait < 0)
        {
            timwait = .5f;
            foreach (var moveComponent in moveComponents)
            {
                MoveWhere(moveComponent);
                moveComponent.persT.position = moveComponent.posVec;
            }
        }
        else
        {
            timwait -= Time.deltaTime;
        }
    }
    private void MoveWhere(MoveComponent move)
    {
        if (move.vector4[3])
        {
            if (!move.checkForMoves[3].cant)
                MoveX(move, false);
            else
                move.vector4[3] = false;
        }
        else if (move.vector4[2])
        {
            if (!move.checkForMoves[2].cant)
                MoveX(move, true);
            else
                move.vector4[2] = false;
        }
        else if (move.vector4[0])
        {
            if (!move.checkForMoves[0].cant)
                MoveY(move, false);
            else
                move.vector4[0] = false;
        }
        else if (move.vector4[1])
        {
            if (!move.checkForMoves[1].cant)
                MoveY(move, true);
            else
                move.vector4[1] = false;
        }
    }
    private void MoveY(MoveComponent moveComponent, bool down = true)
    {
        if (down)
        {
            moveComponent.posVec.y -= .725f;
            moveComponent.posVec.x -= .1f;
            moveComponent.posVec.z -= .05f;
        }
        else
        {
            moveComponent.posVec.y += .725f;
            moveComponent.posVec.x += .1f;
            moveComponent.posVec.z += .05f;
        }
    }
    private void MoveX(MoveComponent moveComponent, bool left = true)
    {
        if (left)
        {
            moveComponent.posVec.x -= .7725f;
        }
        else
        {
            moveComponent.posVec.x += .7725f;
        }
    }
}
