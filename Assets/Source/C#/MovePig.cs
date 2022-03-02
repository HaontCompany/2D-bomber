using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePig : MonoBehaviour
{
    [SerializeField] Transform pigT;
    [SerializeField] CheckForMove[] checkForMoves;
    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer imgMain;
    private Vector3 posVec;
    void Start()
    {
        posVec = pigT.position;
        checkForMoves = new CheckForMove[pigT.childCount];
        for (int i = 0; i < pigT.childCount; i++)
        {
            checkForMoves[i] = pigT.GetChild(i).GetComponent<CheckForMove>();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            UImoveY(false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            UImoveY(true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            UImoveX(true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            UImoveX(false);
        }
        pigT.position = posVec;
    }
    public void UImoveY(bool down)
    {
        if (!down)
        {
            if (!checkForMoves[0].cant)
                MoveY(false);
            imgMain.sprite = sprites[0];
        }
        else
        {
            if (!checkForMoves[1].cant)
                MoveY(true);
            imgMain.sprite = sprites[1];
        }
    }
    public void UImoveX(bool left)
    {
        if (!left)
        {
            if (!checkForMoves[3].cant)
                MoveX(false);
            imgMain.sprite = sprites[3];
        }
        else
        {
            if (!checkForMoves[2].cant)
                MoveX(true);
            imgMain.sprite = sprites[2];
        }
    }
    private void MoveY(bool down = true)
    {
        if (down)
        {
            posVec.y -= .725f;
            posVec.x -= .1f;
            posVec.z -= .05f;
        }
        else
        {
            posVec.y += .725f;
            posVec.x += .1f;
            posVec.z += .05f;
        }
    }
    private void MoveX(bool left = true)
    {
        if (left)
        {
            posVec.x -= .7725f;
        }
        else
        {
            posVec.x += .7725f;
        }
    }
}
