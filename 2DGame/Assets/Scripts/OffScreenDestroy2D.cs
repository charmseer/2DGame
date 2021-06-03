using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreenDestroy2D : MonoBehaviour
{
    private float LeftBound = -55.0f;
    private float RightBound = 55.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < LeftBound)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.x > RightBound)
        {
            Destroy(gameObject);
        }
    }
}
