using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{
    public Rigidbody2D myRigibody2d;
    public float flaphStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigibody2d.velocity = Vector2.up * flaphStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
