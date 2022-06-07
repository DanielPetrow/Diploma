using UnityEngine;

public class Torque : MonoBehaviour
{
    public float _speed = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
    }
}
