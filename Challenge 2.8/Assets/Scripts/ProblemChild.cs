using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemChild : MonoBehaviour
{
    Vector2 xMove;
    Transform Player;
    Animator a;
    Rigidbody2D rb;
    float thrust = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        xMove = new Vector2(0.0f, 0.0f);
        Player = gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float rightleft = Input.GetAxis("Horizontal");
        a.SetFloat("Speed", Mathf.Abs(rightleft));
        float upDown = Input.GetAxis("Vertical");
        xMove.y = upDown;
        xMove.x = rightleft;

        Player.Translate(xMove * Time.deltaTime);
        if (rightleft > 0)
        {
            Player.localScale = new Vector2(5.0f, 5.0f);
        }
        if (rightleft < 0)
        {
            Player.localScale = new Vector2(-5.0f, 5.0f);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(transform.up);
            a.SetBool("Jump", true);
        }
        else
        {
            a.SetBool("Jump", false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * thrust);
        }
    }
    void OnBecomeInvisible()
    {
        Destroy(gameObject);
    }
    
    
}