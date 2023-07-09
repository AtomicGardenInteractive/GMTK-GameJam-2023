using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnControls : MonoBehaviour
{
    [SerializeField] public bool EnemyTurn = false;
    [SerializeField] public bool PlayerHasControl = true; //can be used later while animations are playing
    [SerializeField] private int TurnCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyTurn){
            PlayerHasControl = false;
        }
    }

    public void StartEnemyTurn()
    {
        EnemyTurn = true;
        PlayerHasControl = false;
    }

    public void StartPlayerTurn()
    {
        EnemyTurn = false;
        PlayerHasControl = true;
    }

    public void TurnDone()
    {
        TurnCounter += 1;
        StartPlayerTurn();
    }

    public int GetTurn()
    {
        return TurnCounter;
    }
}
