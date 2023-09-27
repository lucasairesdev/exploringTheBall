using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentCamera : MonoBehaviour
{

    public GameObject objetoPlayer;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position - objetoPlayer.transform.position;
    }

   
    void Update()
    {
        transform.position = objetoPlayer.transform.position + initialPosition;
    }
}
