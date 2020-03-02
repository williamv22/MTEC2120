using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandWithSpace : MonoBehaviour
{
    private float maxDiameter = 5;
    private float minDiameter= 1;
    bool hasControl;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasControl)
        {
            if (Input.GetKey(KeyCode.Space))
                transform.localScale += Vector3.one * Time.deltaTime;

            if (transform.localScale.x >= maxDiameter)
                hasControl = false;
        }
        else
        {
            transform.localScale += -Vector3.one * Time.deltaTime;

            if (transform.localScale.x <= minDiameter)
                hasControl = true;
        }
      
     
    }
}
