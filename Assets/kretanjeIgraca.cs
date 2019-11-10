using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kretanjeIgraca : MonoBehaviour
{
    public float moveSpeed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public bool isGrounded;
    private Rigidbody2D rigid;
    public float jumpHeight = 10f;
    public Sprite left,right;
    public Text scor;
    int score;
    
    void Start()
    {
        score = 0;
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        MoveRight();
        MoveLeft();
        if (score == 13)
        {
            DontDestroyOnLoad(scor);
            SceneManager.LoadScene(4);
        }
    }

    void Jump()
    {
        //if (Input.GetButton("Jump") && isGrounded) 
        //{
        //    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 0.1f), ForceMode2D.Impulse);
        //}
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpHeight);
        }
    }
    
    void MoveRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x +moveSpeed, transform.position.y);
            gameObject.GetComponent<SpriteRenderer>().sprite = right;
        }
    }
    void MoveLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x -moveSpeed, transform.position.y);
            gameObject.GetComponent<SpriteRenderer>().sprite = left;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "slovo")
        {
            Destroy(col.gameObject);
            score++;
            scor.text = score.ToString();
            Debug.Log(score);
        }
    }

    }


