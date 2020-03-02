using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpWithW : MonoBehaviour
{
    private float maxHeight = 5;
    private float minHeight = -5;
    private bool hasControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasControl == true)
        {
            if (Input.GetKey(KeyCode.W))
                transform.position += Vector3.up * Time.deltaTime;

            if (transform.position.y >= maxHeight)
                hasControl = false;
        }
        else
        {
            transform.position += Vector3.down * Time.deltaTime;

            if (transform.position.y < minHeight)
                hasControl = true;
        }
        
     
        
    }
}
