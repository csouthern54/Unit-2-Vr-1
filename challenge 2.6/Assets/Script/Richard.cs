using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Richard : MonoBehaviour
{
    Transform sprite;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        sprite = gameObject.transform;
        move = new Vector2(0.1f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float myX = Input.GetAxis("Horizontal");
        move.x = myX;
        sprite.Translate(move * Time.deltaTime);
    }
}
