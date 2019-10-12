using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



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
    public Vector3 pos, pos2;




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
        Falldown();
                     
        

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
                        //addforce이용 jumpSpeed = 250
                        //Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
                        //rigidbody2D.AddForce(Vector3.up * jumpSpeed);

                        //velocity이용 jummpSpeed = 6
                        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
                        
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

    void Falldown()
    {
       

        if (jumpCount == 2)
        {
            //현재높이
            pos = this.gameObject.transform.position;
            Debug.Log(pos.y);
        }
        
        
        
        if (jumpCount < 2)
        {
            //가변높이
            pos2 = this.gameObject.transform.position;
            Debug.Log(pos2.y);
            
            //if (Mathf.Abs(pos2.y) - Mathf.Abs(pos.y) > Mathf.Abs(2))
            if(Mathf.Abs(pos.y) - Mathf.Abs(pos2.y) > 3)
            {
                GameObject.Find("Main Camera").GetComponent<_Gm>().gameovertrigger = true;
            }
        }
    }





}