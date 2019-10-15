﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl : MonoBehaviour
{
    public GameObject[] Block;// 일반블럭
    public GameObject Arrive;// 도착블럭
    public GameObject Nomal;
    static int i = 0;
  
    public int end = 0;//블럭 갯수
    float randomX = 0;
    float randomY = 0;
    float randomx = 0;
    float randomy = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Create");
        
       
    }
    // Update is called once per frame

    void Update()
    {
        if (i>end-2)
            StopCoroutine("Create");
    }

    IEnumerator Create()
    {

        int percent = 0;
        Vector3 vector;
        vector = Nomal.transform.position;
        vector.y = -30f;
        Nomal.transform.position = vector;
        while (true)
        {
            yield return null;
            percent = Random.Range(0, 4);

            randomX = Random.Range(-12f, 12f);//Position x 조절
            randomY = Random.Range(3f, 4f);//Position y 조절

            Nomal = Instantiate(Block[percent], new Vector3(randomX, Nomal.transform.position.y + randomY, 0f), Quaternion.identity);//일반블럭 생성과 Position
           

            i++;

            if (i > end - 2)
                Instantiate(Arrive, new Vector3(0f, Nomal.transform.position.y + randomY, 0f), Quaternion.identity);//도착블럭 생성과 Position
        }
    }

}
