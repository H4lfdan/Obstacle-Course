using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;
    void Start()
    {
       PrintInstruction();
    }

    void Update()
    {
         MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move Buster with WASD");
        Debug.Log("Please don't phase through the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed ;

        transform.Translate(xValue,0,zValue);
    }

}
