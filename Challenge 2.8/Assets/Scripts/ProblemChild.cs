using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemChild : MonoBehaviour
{
    Vector2 xMove;
    Transform Player;
    Animator animator;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        xMove = new Vector2(0.0f, 0.0f);
        Player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float rightleft = Input.GetAxis("Horizontal");
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
    }
}