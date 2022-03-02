using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputForMove : MonoBehaviour
{
    [SerializeField] MoveComponent moveComponent;
    [SerializeField] Sprite[] sprites;
    [SerializeField] SpriteRenderer imgMain;
    private int max;
    private float timereset;
    void Update()
    {
        if (timereset < 0)
        {
            max = 0;
            timereset = .1f;
            foreach (var vec in moveComponent.vector4)
            {
                if (!vec)
                    max++;
            }
            if (max == 4)
            {
                bool forrand = false;
                while (!forrand)
                {
                    int rand = Random.Range(0, 4);
                    if (!moveComponent.checkForMoves[rand].cant)
                    {
                        moveComponent.vector4[rand] = true;
                        forrand = true;
                        imgMain.sprite = sprites[rand];
                    }
                }
            }
        }
        else
        {
            timereset -= Time.deltaTime;
        }
    }
}
