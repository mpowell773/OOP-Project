using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    [SerializeField] float speed;
    [SerializeField] float turnSpeed = 4.0f;

    [SerializeField] float turnAngle = 90.0f;
    private float rotationX;
 
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //Cursor locked to center of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardMovement();
        MouseMovement();
    }

    void KeyboardMovement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        // Left/Right movement
        transform.Translate(Vector3.right * horizontalMovement * speed * Time.deltaTime);
        // Forward/Back movement
        transform.Translate(Vector3.forward * verticalMovement * speed * Time.deltaTime);
    }

    void MouseMovement()
    {
        // Mouse inputs 
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotationX += Input.GetAxis("Mouse Y") * turnSpeed;

        // Limit vertical rotation
        rotationX = Mathf.Clamp(rotationX, -turnAngle, turnAngle);

        transform.eulerAngles = new Vector3(-rotationX, transform.eulerAngles.y + y, 0);
    }
}
