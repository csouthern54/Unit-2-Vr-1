using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingUp : MonoBehaviour
{
    Vector2 moveUp;
    Transform camera;
   // Start is called before the first frame update
    void Start()
    {
       moveUp = new Vector2(0.0f, 0.5f);
       camera = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
       camera.Translate(moveUp * Time.deltaTime);
    }
}
