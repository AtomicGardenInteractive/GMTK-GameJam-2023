using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInfo : MonoBehaviour
{
    public enum pieceType {pawn,knight,bishop,rook,queen}
    public pieceType playerPiece = pieceType.rook;
    public int playerTakes = 0;
    public Text pieceText;
    public UiManager TheUI;
    public void setPiece(pieceType theNewPiece)
    {
        playerPiece = theNewPiece;
    }

    public pieceType getPiece()
    {
        return playerPiece;
    }

    public int getTakes()
    {
        return playerTakes;
    }

    public void addTake()
    {
        TheUI.addToTakesText();
        playerTakes++;
        checkIfLevelUp();
    }

    public void checkIfLevelUp()
    {
        if(playerPiece != pieceType.queen)
        {
            if (playerTakes % 3 == 0)
            {
                playerPiece++;
                pieceText.text = "Current Piece: " + playerPiece.ToString();
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        pieceText.text = "Current Piece: " + playerPiece.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
