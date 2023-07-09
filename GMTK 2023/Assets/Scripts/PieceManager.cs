using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{

    #region Game Piece Fields
        [SerializeField] private GameObject TurnController;

        [SerializeField] private GameObject wPawn1;
        [SerializeField] private GameObject wPawn2;
        [SerializeField] private GameObject wPawn3;
        [SerializeField] private GameObject wPawn4;
        [SerializeField] private GameObject wPawn5;
        [SerializeField] private GameObject wPawn6;
        [SerializeField] private GameObject wPawn7;
        [SerializeField] private GameObject wPawn8;
        [SerializeField] private GameObject wRook1; //Left
        [SerializeField] private GameObject wRook2; //Right
        [SerializeField] private GameObject wKnight1; //Left
        [SerializeField] private GameObject wKnight2; //Right
        [SerializeField] private GameObject wBishop1; //Left
        [SerializeField] private GameObject wBishop2; //Right
        [SerializeField] private GameObject wKing;
        [SerializeField] private GameObject wQueen;
    
        [SerializeField] private GameObject bPawn1;
        [SerializeField] private GameObject bPawn2;
        [SerializeField] private GameObject bPawn3;
        [SerializeField] private GameObject bPawn4;
        [SerializeField] private GameObject bPawn5;
        [SerializeField] private GameObject bPawn6;
        [SerializeField] private GameObject bPawn7;
        [SerializeField] private GameObject bPawn8;
        [SerializeField] private GameObject bRook1; //Left
        [SerializeField] private GameObject bRook2; //Right
        [SerializeField] private GameObject bKnight1; //Left
        [SerializeField] private GameObject bKnight2; //Right
        [SerializeField] private GameObject bBishop1; //Left
        [SerializeField] private GameObject bBishop2; //Right
        [SerializeField] private GameObject bKing;
        [SerializeField] private GameObject bQueen;
    #endregion

    private object[,] moves;
    // Start is called before the first frame update
    void Start()
    {
        moves = new object[16,3]{
            {bKnight1, 0,5},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4},
            {bKnight1, 2,4}

        };
    }

    // Update is called once per frame
    void Update()
    {
        if(TurnController.GetComponent<TurnControls>().EnemyTurn)
        {
            int turn = TurnController.GetComponent<TurnControls>().GetTurn();
            if(turn > moves.Length)
            {

            }
            else
            {
                GameObject peice = (GameObject)moves[turn, 0];
                peice.GetComponent<PieceAttributes>().GoTo((int)moves[turn, 1], (int)moves[turn, 2]);
                TurnController.GetComponent<TurnControls>().TurnDone();
            }
        }
    }

    

}
