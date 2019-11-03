using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject target; //유저
    public float moveSpeed; //속도
    private Vector3 targetPostion; //대상의 현재위치값
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.gameObject != null) {
            targetPostion.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPostion, moveSpeed * Time.deltaTime);

        }
        
    }
}
