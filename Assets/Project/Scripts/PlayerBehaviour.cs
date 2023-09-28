using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{

    private Rigidbody myRigidbody;
    public Transform cameraTransform;

    public GameObject particulaItem;

    public Text scoreText;
    public Text endGameText;

    private int scoreGame;
       
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        endGameText.text = "";
        //endGameText.IsActive = false;

        UpdateScoreUI();
    }

    void FixedUpdate()
    {
        //Quando o W é pressionado, o eixo Vertical vai retornar 1.
        Vector3 movimentPlayer = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // só o W pressionado = Vector3(0, 0, 1)
        Debug.Log("movimentPlayer: " + movimentPlayer);
        myRigidbody.AddForce(movimentPlayer * 10);
    }


    private void OnTriggerEnter(Collider other) {

        if(other.gameObject.CompareTag("items")) {
            Instantiate(particulaItem, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            UpdateScoreUI();



        }
    }

    void UpdateScoreUI() {
        
        scoreText.text = "Score: " + scoreGame.ToString();
        scoreGame++;

        if(scoreGame == 10) {
            endGameText.text = "You Win!";
        }
    }
}
