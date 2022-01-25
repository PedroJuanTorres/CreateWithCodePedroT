using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float carSpeed = 0.0f;
    [SerializeField] private float turnSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
