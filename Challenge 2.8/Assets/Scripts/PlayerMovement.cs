using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 move;

    Transform player;

    float xMovement;
    public int xSpeed = 4;

    public Animator animator;

    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 5.0f;

    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        m_Rigidbody = GetComponent<Rigidbody2D>();
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //Moving Script
        xMovement = Input.GetAxis("Horizontal") * xSpeed;

        animator.SetFloat("Speed", Mathf.Abs(xMovement));

        move = new Vector2(xMovement, 0.0f);

        player.Translate(move * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(4, 4, 1);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-4, 4, 1);
        }
        //Moving Script

        //Jumping script
        if (m_Rigidbody.velocity.y == 0)
        {
            if (Input.GetButton("Jump"))
            {
                animator.SetBool("Jumping", true);
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
            else
            {
                animator.SetBool("Jumping", false);
            }
        }
        //Jumping Script


        if (health == 0)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Acorn")
        {
            Debug.Log("Nom Nom");
        }

        if (collision.gameObject.tag == "Ant")
        {
            Debug.Log("Ouch");
            health = health - 1;
        }
    }
    void OnBecameInvisible()
    {
        Debug.Log("Game Over");
        health = 0;
        Destroy(gameObject);
    }
}