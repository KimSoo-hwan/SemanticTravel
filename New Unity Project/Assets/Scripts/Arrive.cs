using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Arrive : MonoBehaviour
{
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
            Debug.Log("1초후 다음 스테이지로");
            Invoke("Next", 1f);

        }
    }
    void Next()
    {
        SceneManager.LoadScene("Sematic Travel 1");
    }
}
