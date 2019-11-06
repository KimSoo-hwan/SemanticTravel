using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Arrive : MonoBehaviour
{

    static int i = 1;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "New tag")
        {
                BlockControl1.i = 0;
                BlockControl1.up = 0f;
                BlockControl2.Move2 = 0;
                BlockControl2.i = 0;
                BlockControl2.up = 0f;
                BlockControl2.temp = 0;
                BlockControl3.Move2 = 0;
                BlockControl3.i = 0;
                BlockControl3.up = 0f;
                BlockControl3.temp = 0;

            

            Debug.Log("1초후 다음 스테이지로");
            Invoke("Next", 1f);


        }
    }
    void Next()
    {
        if (i == 1)
        {
            SceneManager.LoadScene("Sematic Travel 1");
            i = 2;
        }
        else if (i == 2)
        SceneManager.LoadScene("Sematic Travel 2");
    }
}
