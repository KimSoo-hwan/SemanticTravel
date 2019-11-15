using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl1 : MonoBehaviour
{
    public GameObject[] Block;// 일반블럭
    public GameObject Arrive;// 도착블럭
    public GameObject Nomal;
    public static int i = 0;
    public static float up = 0f;

    public int end = 0;//블럭 갯수
    
    float randomY = 0;
    int randomx = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector;
        vector = Nomal.transform.position;
        vector.y = 0f;
        Nomal.transform.position = vector;

        up = transform.position.y;

        StartCoroutine("Create");


    }
    // Update is called once per frame

    void Update()
    {
        if (i == end - 1)
        {
            Instantiate(Arrive, new Vector3(0f, up + 2f, 0f), Quaternion.identity);
            StopCoroutine("Create");
            i++;
            }

    }

    IEnumerator Create()
    {

        int percent = 0;

        while (true)
        {
            yield return null;
            percent = Random.Range(0, 4);
            
            
            randomY = Random.Range(2f, 2.5f);//Position y 조절
            randomx = Random.Range(1, 4);

           // Debug.Log(percent);
            
            Nomal = Instantiate(Block[percent], new Vector3(0f, up, 0f), Quaternion.identity);
            up += randomY;



            if (percent >= 0 && percent <= 3 && randomx == 1)
                Nomal.transform.position = new Vector3(0f, up , 0f);
            else if (percent >= 0 && percent <= 3 && randomx == 2)
                Nomal.transform.position = new Vector3(-1.8f, up , 0f);
            else if (percent >= 1 && percent <= 2 && randomx == 2)
                Nomal.transform.position = new Vector3(-1.3f, up , 0f);
            else if (percent >= 3 && randomx == 2)
                Nomal.transform.position = new Vector3(-0.8f, up , 0f);
            else if (percent >= 0 && percent <= 3 && randomx == 3)
                Nomal.transform.position = new Vector3(1.8f, up , 0f);
            else if (percent >= 1 && percent <= 2 && randomx == 3)
                Nomal.transform.position = new Vector3(1.3f, up , 0f);
            else if (percent >= 3 && randomx == 3)
                Nomal.transform.position = new Vector3(0.8f, up, 0f);


            i++;
            yield return null;

        }
    }

}
