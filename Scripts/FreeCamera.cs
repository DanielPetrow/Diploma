using UnityEngine;
using UnityEngine.EventSystems;

public class FreeCamera : MonoBehaviour
{
    public Texture2D _cursorDefault, _cursorMove;

    public float _movementSpeed = 10f;
    public float _fasterMovementSpeed = 5f;
    public float _lookingAroundSensitivity = 3f;

    private float rotX, rotY;

    private bool lookingAround = false;

    private Vector3 defaultPosition;

    private void Start()
    {
        defaultPosition = gameObject.transform.position;
        Cursor.SetCursor(_cursorDefault, new Vector2(10, 5), CursorMode.ForceSoftware);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += transform.up * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.position += -transform.up * _movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.R))
        {
            transform.position = defaultPosition;
            transform.localEulerAngles = Vector3.zero;
        }

        if (lookingAround)
        {
            rotX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _lookingAroundSensitivity;
            rotY = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * _lookingAroundSensitivity;
            transform.localEulerAngles = new Vector3(rotY, rotX, 0f);
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                _movementSpeed -= _fasterMovementSpeed;
            }
            else if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                _movementSpeed += _fasterMovementSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            StartLooking();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            StopLooking();
        }
    }

    private void OnDisable()
    {
        StopLooking();
    }

    private void StartLooking()
    {
        lookingAround = true;
        Cursor.SetCursor(_cursorMove, new Vector2(10, 5), CursorMode.ForceSoftware);
    }

    private void StopLooking()
    {
        lookingAround = false;
        Cursor.SetCursor(_cursorDefault, new Vector2(10, 5), CursorMode.ForceSoftware);
    }
}
