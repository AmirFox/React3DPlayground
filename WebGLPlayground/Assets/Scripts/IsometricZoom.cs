using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricZoom : MonoBehaviour
{
    public float moveIncrement = 1.0f; // Set this value in the Unity Inspector.

    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Reset the movement vector to (0, 0, 0) each frame.
        movement = Vector3.zero;

        // Diagonal movement
        if (Input.GetKey(KeyCode.W))
        {
            movement += Vector3.forward.normalized * moveIncrement;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += Vector3.back.normalized * moveIncrement;
        }

        // Apply the accumulated movement to the object's position.
        transform.Translate(movement);
    }
}
