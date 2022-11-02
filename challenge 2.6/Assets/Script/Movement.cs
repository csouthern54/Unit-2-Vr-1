using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 Move;
    Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        Move = new Vector2(0.0f, 0.0f);
       
    }

    // Update is called once per frame
    void Update()
    {
        float myx = Input.GetAxis("Horizontal");
        Move.x = myx;
            player.Translate(Move*Time.deltaTime); 

    }
}
