﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target; //유저
    public float moveSpeed; //속도
    private Vector3 targetPostion; //대상의 현재위치값
    public bool cameraMoveTriiger = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraMoveTriiger == false && GameObject.Find("Player").GetComponent<PlayerMove>().gameStart == true)
        {
            cameraMoveTriiger = true;
        }
        if (target.gameObject != null && cameraMoveTriiger == true)
        {
            targetPostion.Set(0, target.transform.position.y+3.0f, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPostion, moveSpeed * Time.deltaTime);

        }

    }
}
