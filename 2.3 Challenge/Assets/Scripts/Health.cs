using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int hearts;
    // Start is called before the first frame update
    void Start()
    {
        hearts = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hearts);
        hearts = hearts - 1;
    }
}
