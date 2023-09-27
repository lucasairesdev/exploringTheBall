using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    private Rigidbody myRigidbody;
    public Transform cameraTransform;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();  
    }

    void FixedUpdate()
    {
        //Quando o W é pressionado, o eixo Vertical vai retornar 1.
        Vector3 movimentPlayer = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // só o W pressionado = Vector3(0, 0, 1)
        Debug.Log("movimentPlayer: " + movimentPlayer);
        myRigidbody.AddForce(movimentPlayer * 10);
    }
}
