using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cirby : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public Vector2 velocity;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        bool mouseDown = Input.GetMouseButtonDown(0);

        if (mouseDown)
        {
            rigidbody2D.velocity = velocity;
        }
        
    }
}
