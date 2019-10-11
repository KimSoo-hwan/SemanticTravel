using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 0.07f;
    public float moveSpeedKeyboard = 5f;
    public float dirX;
    public float jumpSpeed = 250f;

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

    void Update()
    {
    
        GameStat();
        PlayerJump();
        Player_Move();

    }

    //바닥 충돌체크함수 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGorunded = true;
            jumpCount = 2;
            GetComponent<AudioSource>().Play();
            Debug.Log("Ground col");
        }
    }

    //최초시작버튼
    void GameStat()
    {
        if (gameStart == false && Input.GetMouseButtonDown(0))
        {
            gameStart = true;
            Destroy(touchtoStart);

        }
    }

    //점프
    void PlayerJump()
    {
        if (gameStart == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            
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

        }
    }

    void Player_Move()
    {
        //기울기 플레이어 조작함수, - 더 좋은 코드를 찾는중입니다.
        //유니티리모트 안쓰고 컴퓨터에서 디버깅할때는 주석처리바람    
        if (gameStart == true)
        {
            dirX = Input.acceleration.x * moveSpeed;
            transform.Translate(dirX, 0, 0);


            //좌로이동,키보드 디버깅용
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Vector2 scale = transform.localScale;
                scale.x = -Mathf.Abs(scale.x);
                transform.localScale = scale;
                transform.Translate(Vector2.left * moveSpeedKeyboard * Time.deltaTime);
            }

            //우로이동,  키보드 디버깅용
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector2 scale = transform.localScale;
                scale.x = -Mathf.Abs(scale.x);
                transform.localScale = scale;
                transform.Translate(Vector2.right * moveSpeedKeyboard * Time.deltaTime);

            }
        }
    }





}