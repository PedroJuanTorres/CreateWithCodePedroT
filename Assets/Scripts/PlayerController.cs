using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float carSpeed = 10.0f;
    [SerializeField] private float turnSpeed = 25.0f;

    private float horizontalInput = 0.0f;
    private float forwardInput = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * forwardInput);

        //Rotate vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
