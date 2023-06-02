using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    [SerializeField] float moveSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController();
    }


    void PrintInstruction()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Move Player with WASD");
        Debug.Log("Don't hit the walls!");
    }

    void PlayerController()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue); 
    }

}
