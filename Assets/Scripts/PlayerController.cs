using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * horizontalMovement * speed);
        playerRb.AddForce(Vector3.forward * verticalMovement * speed);

    }
}
