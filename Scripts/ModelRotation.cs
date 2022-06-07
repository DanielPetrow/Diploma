using UnityEngine;

public class ModelRotation : MonoBehaviour
{
    public float _rotationSpeed = 150f;

    private float rotationX, rotationY;

    private void OnMouseDrag()
    {
        rotationX = Input.GetAxis("Mouse X") * _rotationSpeed * Mathf.Deg2Rad;
        rotationY = Input.GetAxis("Mouse Y") * _rotationSpeed * Mathf.Deg2Rad;

        gameObject.transform.Rotate(rotationY, -rotationX, 0, Space.World);
    }
}
