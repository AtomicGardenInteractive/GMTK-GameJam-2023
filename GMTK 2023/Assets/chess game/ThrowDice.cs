using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDice : MonoBehaviour
{
    [SerializeField] private GameObject dice1;
    [SerializeField] private GameObject dice2;

    private Rigidbody dice1RB;
    private Rigidbody dice2RB;

    private bool canThrow = true;

    // Start is called before the first frame update
    void Start()
    {
        dice1RB = dice1.GetComponent<Rigidbody>();
        dice2RB = dice2.GetComponent<Rigidbody>();
        dice1RB.useGravity = false;
        dice2RB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canThrow && Input.GetKey(KeyCode.Space))
        {
            dice1RB.useGravity = true;
            dice2RB.useGravity = true;
            canThrow = false;
            dice1RB.AddForce(10f, 5f, 10f);
            dice2RB.AddForce(10f, -5f, 10f);
        }
    }
}
