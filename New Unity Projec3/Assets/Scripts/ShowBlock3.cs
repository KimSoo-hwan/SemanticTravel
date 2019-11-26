using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBlock3 : MonoBehaviour
{
    public bool Showblcok = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Showblcok = GameObject.Find("Player").GetComponent<PlayerMove>().gameStart;
        if (Showblcok == true)
        {
            gameObject.GetComponent<BlockControl3>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<BlockControl3>().enabled = false;
        }

    }
}
