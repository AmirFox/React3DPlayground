using UnityEngine;

public class IsometricMovement : MonoBehaviour
{
    public float moveIncrement = 1.0f; // Set this value in the Unity Inspector.

    private Vector3 movement;

    public void MoveUp()
    {
            movement += (Vector3.forward - Vector3.left).normalized * moveIncrement;
    }

    public void MoveLeft()
    {
            movement += (Vector3.forward - Vector3.right).normalized * moveIncrement;
    }

    public void MoveRight()
    {
        movement += (Vector3.back - Vector3.left).normalized * moveIncrement;
    }

    public void MoveDown()
    {
        movement += (Vector3.back - Vector3.right).normalized * moveIncrement;
    }

    void Update()
    {
        // Apply the accumulated movement to the object's position.
        transform.Translate(movement);
        movement = Vector3.zero;
    }
}
