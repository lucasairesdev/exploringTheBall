using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private Rigidbody myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();  
    }

    void FixedUpdate()
    {
        Vector3 movimentPlayer = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        myRigidbody.AddForce(movimentPlayer);
    }
}
