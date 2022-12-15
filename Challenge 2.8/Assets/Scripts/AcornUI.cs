using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcornUI : MonoBehaviour
{
    public float Acorns;
    public Text AcornText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AcornText.text = "Acorn Count: " + Acorns;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "acorn")
        {
            Acorns += 1;
        }
    }
}
