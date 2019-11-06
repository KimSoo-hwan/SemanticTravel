using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D ob)
    {
        Debug.Log("Collision");
        if (ob.gameObject.tag == "New tag")
        {
            StartCoroutine(delay());
        }

    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(this.gameObject);
    }
}
