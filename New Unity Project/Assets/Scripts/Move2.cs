using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : BlockControl2
{
    float k = BlockControl2.up;
    float upMax = 0; //좌로 이동가능한 (x)최대값
    float downMax = 0; //우로 이동가능한 (x)최대값
    float currentPosition; //현재 위치(x) 저장
    float direction = 2.0f; //이동속도+방향

    Vector3 vector;
    
    
    
    void Start()
    {
         upMax = k + 2f; //좌로 이동가능한 (x)최대값
         downMax = k - 1f; //우로 이동가능한 (x)최대값

        currentPosition = transform.position.y ;

    }

    void Update()
    {
        

        currentPosition += Time.deltaTime * direction;
        if (currentPosition >= upMax)
        {
            direction *= -1;
            currentPosition = upMax;
        }
        else if (currentPosition <= downMax)
        {
            direction *= -1;
            currentPosition = downMax;
        }

        vector = transform.position;
        vector.y = currentPosition;
        transform.position = vector;
    }
}
