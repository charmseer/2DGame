using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerv1 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 15.0f;

    //Boundaries within which player can move
    private float xRangeR = 15.0f;
    private float xRangeL = 19.0f;
    private float yRange = 9.0f;

    //Making slot to drag and drop Projectile in Unity
    public GameObject projectilePrefab;





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

        // Resets position of player when player tries to move beyond play area
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

        //Launches projectile from player
        if(Input.GetKeyDown(KeyCode.Space))
            {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            }
    }
}
