using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl3 : MonoBehaviour
{
    public GameObject[] Block;// 일반블럭
    public GameObject Arrive;// 도착블럭
    public GameObject Nomal;
    public static int i = 0;
    public static int temp = 0;
    public static float up = 0f;
    public static float Move2 = 0;

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
            Instantiate(Arrive, new Vector3(0f, up, 0f), Quaternion.identity);
            StopCoroutine("Create");
            i++;

        }

    }



    IEnumerator Create()
    {
        int percent;



        while (true)
        {




            percent = Random.Range(0, 7);//블럭 생성 확률


            Debug.Log(temp);
            randomY = Random.Range(2f, 2.5f);//Position y 조절



            randomx = Random.Range(1, 4);// 1 = 가운데, 2 = 왼쪽, 3 = 오른쪽

            if (temp == 5)
                Move2 = 2f;
            else
                Move2 = 0f;

            up += randomY + Move2;

            yield return null;



            Nomal = Instantiate(Block[percent], new Vector3(0f, up, 0f), Quaternion.identity);






            if ((percent >= 0 && percent <= 3 && randomx == 1) || (percent == 5 && randomx == 1) || (percent == 6 && randomx == 1))
                Nomal.transform.position = new Vector3(0f, up, 0f);
            else if (percent >= 0 && percent <= 3 && randomx == 2)
                Nomal.transform.position = new Vector3(-1.8f, up, 0f);
            else if ((percent >= 1 && percent <= 2 && randomx == 2) || (percent == 5 && randomx == 2) || (percent == 6 && randomx == 2))
                Nomal.transform.position = new Vector3(-1.3f, up, 0f);
            else if (percent >= 3 && randomx == 2)
                Nomal.transform.position = new Vector3(-0.8f, up, 0f);
            else if (percent >= 0 && percent <= 3 && randomx == 3)
                Nomal.transform.position = new Vector3(1.8f, up, 0f);
            else if ((percent >= 1 && percent <= 2 && randomx == 3) || (percent == 5 && randomx == 3) || (percent == 6 && randomx == 3))
                Nomal.transform.position = new Vector3(1.3f, up, 0f);
            else if (percent >= 3 && randomx == 3)
                Nomal.transform.position = new Vector3(0.8f, up, 0f);
            else if (percent == 4)
                Nomal.transform.position = new Vector3(0f, up, 0f);



            temp = percent;

            i++;

        }

    }

}
