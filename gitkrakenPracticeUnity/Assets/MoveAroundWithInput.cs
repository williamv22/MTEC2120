using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAroundWithInput : MonoBehaviour
{
    public bool moveUp;
    public bool moveDown;
    public bool moveLeft;
    public bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(moveUp)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if(moveDown)
        {
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if(moveRight)
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if(moveLeft)
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        */

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }
}
