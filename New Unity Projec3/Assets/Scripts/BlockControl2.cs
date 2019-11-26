using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockControl2 : MonoBehaviour
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
        int percent=0;
        int count;


        while (true)
        {


            

            count = Random.Range(0, 101);//블럭 생성 확률

            if(count >= 0 && count <= 19)
            percent = 0;
            else if(count >= 20 && count <= 39)
            percent = 1;
            else if(count >= 40 && count <= 69)
            percent = 2;
            else if(count >= 70 && count <= 85)
            percent = 3;
            else if(count >= 80 && count <= 100)
            percent = 4;

            
            randomY = Random.Range(2f, 2.5f);//Position y 조절

            

            randomx = Random.Range(1, 4);// 1 = 가운데, 2 = 왼쪽, 3 = 오른쪽

            if (temp == 4)
                Move2 = 2f;
            else
                Move2 = 0f;

            up += (randomY + Move2);

            yield return null;



            Nomal = Instantiate(Block[percent], new Vector3(0f, up, 0f), Quaternion.identity);

            

            


            if (percent == 3 || randomx == 1)
                Nomal.transform.position = new Vector3(0f, up , -1f);
            else if (percent == 0 && randomx == 2)
                Nomal.transform.position = new Vector3(-1.8f, up , -1f);
            else if ((percent == 1 || percent == 4) && randomx == 2)
                Nomal.transform.position = new Vector3(-1.3f, up , -1f);
            else if (percent == 2 && randomx == 2)
                Nomal.transform.position = new Vector3(-0.8f, up , -1f);
            else if (percent == 0 && randomx == 3)
                Nomal.transform.position = new Vector3(1.8f, up , -1f);
            else if ((percent == 1 || percent == 4) && randomx == 3)
                Nomal.transform.position = new Vector3(1.3f, up , -1f);
            else if (percent == 2 && randomx == 3)
                Nomal.transform.position = new Vector3(0.8f, up  , -1f);


            temp = percent;
            
            i++;
            
        }
        
    }

}
