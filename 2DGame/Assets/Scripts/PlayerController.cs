using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction movement;
    public float speed = 10.0f;
    public CharacterController controller;
    // Start is called before the first frame update

    void OnEnable()
    {
        movement.Enable();
        
    }

    void OnDisable()
    {
        movement.Disable();
    }


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(movement.ReadValue<Vector2>().ToString());
        Vector2 inputVector = movement.ReadValue<Vector2>();

        Vector3 finalVector = new Vector3();
        finalVector.x = inputVector.x;
        finalVector.z = inputVector.y;



        controller.Move(finalVector * Time.deltaTime * 10f);
    }
}
