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
    public int jumpCount = 1;   //2단점프
    public Text touchtoStart;
    public Vector3 pos, pos2, fallpos;

    public Transform groundCheck;
    public LayerMask whatisGround;
    public float checkRadius;

    public float fallposSlice = 0.25f;
    public float MAXARRAY = 10f;
    public float MINARRAY = 3f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCount = 1;
        gameStart = false;

    }

    void Update()
    {

        GameStat();
        PlayerJump();
        Player_Move();
        Falldown();



    }
    private void FixedUpdate()
    {
        isGorunded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGround);
        if (isGorunded == true)
        {
            isGorunded = true;
            jumpCount = 1;

        }

    }

    //바닥 충돌체크함수 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

            GetComponent<AudioSource>().Play();

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
        if (gameStart == true && GameObject.Find("Main Camera").GetComponent<_Gm>().isPlayerAlive == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;

            if (isGorunded == true)
            {
                jumpCount = 1;
            }

            if (jumpCount > 0)

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

    void Player_Move()
    {
        //기울기 플레이어 조작함수, - 더 좋은 코드를 찾는중입니다.
        //유니티리모트 안쓰고 컴퓨터에서 디버깅할때는 주석처리바람    
        if (gameStart == true && GameObject.Find("Main Camera").GetComponent<_Gm>().isPlayerAlive == true)
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
        Vector3 fallpos; //추락거리
        Vector3 fallLimit; //높이별 추락제한변수


        if (isGorunded == true)
        {
            pos = this.gameObject.transform.position;
        }
        else if (isGorunded == false)
        {
            pos2 = this.gameObject.transform.position;
        }
        fallpos.y = pos.y - pos2.y;


        fallLimit.y = MAXARRAY - (pos.y * fallposSlice);


        if (fallpos.y > fallLimit.y && fallpos.y > MINARRAY)
        {
            GameObject.Find("Main Camera").GetComponent<_Gm>().gameovertrigger = true;
        }
        Debug.Log(fallLimit.y);

    }

    /*
    void Falldown()
    {
        Vector3 logPos1;
        logPos1.y = Mathf.Log10(pos.y);
        fallpos.y = (pos.y * logPos1.y ) * fallposSlice;

        //fallpos.y = pos.y * Mathf.Log10(pos.y);

        //Debug.Log(fallpos.y *0.25);
        if (jumpCount == 1)
        {
            //현재높이

            pos = this.gameObject.transform.position;
             Debug.Log(fallpos.y);
            if (Mathf.Abs(pos2.y) - Mathf.Abs(pos.y) > fallpos.y && Mathf.Abs(pos2.y) - Mathf.Abs(pos.y) > 1)
            {             
                GameObject.Find("Main Camera").GetComponent<_Gm>().gameovertrigger = true;
            }
        }
        if (jumpCount < 1)
        {
            //가변높이
            pos2 = this.gameObject.transform.position;
            Debug.Log(fallpos.y);
            if (Mathf.Abs(pos.y) - Mathf.Abs(pos2.y) > fallpos.y && Mathf.Abs(pos.y) - Mathf.Abs(pos2.y) >1)
            {
                GameObject.Find("Main Camera").GetComponent<_Gm>().gameovertrigger = true;
            }
        }
    }
    */







}