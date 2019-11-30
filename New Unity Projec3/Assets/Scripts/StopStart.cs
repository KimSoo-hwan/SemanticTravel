﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StopStart : MonoBehaviour
{
    public float timeStart = 3;
    public Text textBox;
    

    int del;

    public GameObject StopPanel;
    bool Isbool = false;    //정지상태 유무
    public Sprite Start;    //버튼이미지
    public Sprite Stop;     //버튼이미지
   
    Image myImageComponent;

    void start()
    {
        textBox.text = timeStart.ToString();              
    }

    void Update()
    {
        if (del == 1)
        {           
            timeStart -= Time.deltaTime;    //시간 내려가는거
            textBox.text = Mathf.Round(timeStart).ToString();
            Time.timeScale = 1.0f;
            if (timeStart<=0)
            {                              
                timeStart = 3;
                textBox.text = "";
                Time.timeScale = 1.0f;
                del = 0;                
            }          
        }
    }
    
    public void ActivePauseBt()
    {      
        myImageComponent = GetComponent<Image>();
        if (Isbool == false)    //정지상태가 아닐때 누르면(정지버튼)
        {            
            Time.timeScale = 0;
            Isbool = true;
            StopPanel.SetActive(true);
            myImageComponent.sprite = Stop;
        }
        else if (Isbool == true)    //정지상태일때 누르면(시작버튼)
        {            
            StopPanel.SetActive(false);//명암 그냥 때려박은거임 쉿
           // StartCoroutine("End");
            del = 1;  //카운트다운 시작          
            Time.timeScale = 1.0f;
            Isbool = false;
            timeStart = 3;
            myImageComponent.sprite = Start;    //이미지 바뀌는거
        }
    }
}