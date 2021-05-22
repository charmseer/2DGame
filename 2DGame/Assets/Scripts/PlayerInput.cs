using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction movement;
    public CharacterController controller;
    public GameObject player;
    private int xRange = 17;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void OnEnable()
    {
        movement.Enable();
    }
    private void OnDisable()
    {
        movement.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = movement.ReadValue<Vector2>();
        Vector3 finalVector = new Vector3();

        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;
        // Debug.Log(movement.ReadValue<Vector2>().ToString());
        Debug.Log(finalVector); 
        Debug.Log(player.transform.position);


        if ( player.transform.position.x > xRange)
        {
            player.transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        if (player.transform.position.x < -xRange)
        {
            player.transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        controller.Move(finalVector * Time.deltaTime * 10f);
    }
}
