using UnityEngine;

public class MenuPrefabMover : MonoBehaviour
{
    public float _speed = 15f;

    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(0, _speed, 0);
    }

    private void Update()   
    {
        transform.Rotate(new Vector3(15f, 15f, 15f) * Time.deltaTime);
    }
}
