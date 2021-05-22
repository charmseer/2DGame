using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerv1 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;
    private float xRangeR = 15.0f;
    private float xRangeL = 19.0f;
    private float yRange = 9.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);


        if (transform.position.x < -xRangeL)
        {
            transform.position = new Vector3(-xRangeL, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRangeR)
        {
            transform.position = new Vector3(xRangeR, transform.position.y, transform.position.z);
        }
        
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }


    }
}
