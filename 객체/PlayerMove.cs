using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpSpeed = 300.0f;
    public bool isGorunded = false; //바닥체크
    public bool gameStart = false;
    Rigidbody2D rb;
    public int jumpCount = 2;   //2단점프
    public Text touchtoStart;

    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 0;
        gameStart = false;
        
    }

    //바갇 충돌체크함수
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground")
        {
            isGorunded = true;
            jumpCount = 2;
            Debug.Log("Ground col");
        }
    }


    void Update()
    {
        if (gameStart == false && Input.GetMouseButtonDown(0)) {
            gameStart = true;
            Destroy(touchtoStart);

        }
        if (gameStart == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            //점프함수
            if (jumpCount > 0)
            {
                if (isGorunded == true)
                {
                    if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
                    {
                        Debug.Log("jump");
                        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
                        rigidbody2D.AddForce(Vector3.up * jumpSpeed);
                        //rb.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse);                  
                        jumpCount--;
                        if (jumpCount == 0)
                            isGorunded = false;
                    }
                }
            }

            //좌로이동, 기울기함수로 변경예정
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector2 scale = transform.localScale;
                scale.x = -Mathf.Abs(scale.x);
                transform.localScale = scale;
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            }
            //우로이동, 기울기함수로 변경예정
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector2 scale = transform.localScale;
                scale.x = -Mathf.Abs(scale.x);
                transform.localScale = scale;
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

            }
        }
    }
}
