using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 27.0f;

    private float lowerBound = 27.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x >topBound)
        {
            Destroy(gameObject);
        }

        else  if (transform.position.x < -lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
