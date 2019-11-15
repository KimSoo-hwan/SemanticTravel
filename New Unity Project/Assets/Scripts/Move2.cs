using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour////
{


    float upMax = 0; //좌로 이동가능한 (x)최대값
    float downMax = 0; //우로 이동가능한 (x)최대값
    float currentPosition; //현재 위치(x) 저장
    float direction = 2.0f; //이동속도+방향

    Vector3 vector;




    void Start()
    {
        float k = Arrive.i;
        float a = BlockControl2.up;
        float b = BlockControl3.up;
        float c = BlockControl4.up;
        float d = BlockControl5.up;

        if (k == 2)
        {
            k = a;
        }
        else if (k == 3)
        {
            k = b;
        }
        else if (k == 4)
        {
            k = c;
        }
        else if (k == 5)
        {
            k = d;
        }

        Debug.Log(k);

        upMax = k - 2f; //위로 이동가능한 (y)최대값
        downMax = k - 5f; //아래로 이동가능한 (y)최대값

        currentPosition = transform.position.y;

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
