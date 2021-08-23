using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rigidBodyComponent; 

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        //rigidBodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        //rigidBodyComponent.AddForce(Vector3.forward * 2, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        
    }
}
