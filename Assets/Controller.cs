using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Bat dau");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ban nhan phim A");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Ban nhan phim D");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Ban nhan phim S");
        }
    }
}
