using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] private Transform TilesParent;
    [SerializeField] private GameObject defaultTileWhite;
    [SerializeField] private GameObject defaultTileBlack;
    [SerializeField] private GameObject[,] board;

    [SerializeField] private int boardX;
    [SerializeField] private int boardZ;

    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    [SerializeField] private float offsetZ;

    [SerializeField] private int[] playerPosition = new int[2];

    [SerializeField] private Color playerTileColor;
    [SerializeField] private Color availableTileColor;
    [SerializeField] private Color defaultColorWhite;
    [SerializeField] private Color defaultColorBlack;

    [SerializeField] private GameObject emptyEnemyInfo;
    [SerializeField] private GameObject emptyFriendlyInfo;

    [SerializeField] private playerInfo thePlayer;
    [SerializeField] private List<enemiesInfo> allEnemies = new List<enemiesInfo>();
    [SerializeField] private enemiesInfo enemyToRemove;

    [SerializeField] private List<friendliesInfo> allFriendlies = new List<friendliesInfo>();

    [SerializeField] private GameObject playerPieceObject;

    [SerializeField] private bool isFirstMove = true;

    [SerializeField] private GameObject[] allBlackPieces;
    [SerializeField] private GameObject[] allWhitePieces;

    bool isWhite = true;
    void Start()
    {
        defaultTileBlack.GetComponent<TileInformation>().setColor(defaultColorBlack);
        defaultTileWhite.GetComponent<TileInformation>().setColor(defaultColorWhite);
        board = new GameObject[boardX, boardZ];
        makeBoard(boardX, boardZ);
        setPlayerTile();
        //spawnEnemy();
        addEnemies();
        addFriendlies();
        checkWhichTiles();
        checkIfBothEnemy();
        checkIfBothFriendly();
        

        //thePlayer.playerPiece = playerInfo.pieceType.pawn;
    }

    private void addEnemies()
    {
        board[0, 7].GetComponent<Renderer>().material.color = Color.red;
        board[0, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(0, 7, 0);
        board[1, 7].GetComponent<Renderer>().material.color = Color.red;
        board[1, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(1, 7, 1);
        board[2, 7].GetComponent<Renderer>().material.color = Color.red;
        board[2, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(2, 7, 2);
        board[3, 7].GetComponent<Renderer>().material.color = Color.red;
        board[3, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(3, 7, 3);
        board[4, 7].GetComponent<Renderer>().material.color = Color.red;
        board[4, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(4, 7, 4);
        board[5, 7].GetComponent<Renderer>().material.color = Color.red;
        board[5, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(5, 7, 5);
        board[6, 7].GetComponent<Renderer>().material.color = Color.red;
        board[6, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(6, 7, 6);
        board[7, 7].GetComponent<Renderer>().material.color = Color.red;
        board[7, 7].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(7, 7, 7);
        board[0, 6].GetComponent<Renderer>().material.color = Color.red;
        board[0, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(0, 6, 8);
        board[1, 6].GetComponent<Renderer>().material.color = Color.red;
        board[1, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(1, 6, 9);
        board[2, 6].GetComponent<Renderer>().material.color = Color.red;
        board[2, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(2, 6, 10);
        board[3, 6].GetComponent<Renderer>().material.color = Color.red;
        board[3, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(3, 6, 11);
        board[4, 6].GetComponent<Renderer>().material.color = Color.red;
        board[4, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(4, 6, 12);
        board[5, 6].GetComponent<Renderer>().material.color = Color.red;
        board[5, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(5, 6, 13);
        board[6, 6].GetComponent<Renderer>().material.color = Color.red;
        board[6, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(6, 6, 14);
        board[7, 6].GetComponent<Renderer>().material.color = Color.red;
        board[7, 6].GetComponent<TileInformation>().setToEnemy();
        addToEnemies(7, 6, 15);

    }

    private void addFriendlies()
    {
        //back row
        //board[0, 0].GetComponent<Renderer>().material.color = Color.green;
        board[0, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(0, 0, 0);
        //board[1, 0].GetComponent<Renderer>().material.color = Color.green;
        board[1, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(1, 0, 1);
        // Player piece

        //board[2, 0].GetComponent<Renderer>().material.color = Color.green;
        //board[2, 0].GetComponent<TileInformation>().setToFriendly();
        //addToFriendlies(2, 0, 2);

        //board[3, 0].GetComponent<Renderer>().material.color = Color.green;
        board[3, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(3, 0, 3);
        //board[4, 0].GetComponent<Renderer>().material.color = Color.green;
        board[4, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(4, 0, 4);
        //board[5, 0].GetComponent<Renderer>().material.color = Color.green;
        board[5, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(5, 0, 5);
        //board[6, 0].GetComponent<Renderer>().material.color = Color.green;
        board[6, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(6, 0, 6);
        //board[7, 0].GetComponent<Renderer>().material.color = Color.green;
        board[7, 0].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(7, 0, 7);

        //front row
       // board[0, 1].GetComponent<Renderer>().material.color = Color.green;
        board[0, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(0, 1, 8);
        //board[1, 1].GetComponent<Renderer>().material.color = Color.green;
        board[1, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(1, 1, 9);
        //board[2, 1].GetComponent<Renderer>().material.color = Color.green;
        board[2, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(2, 1, 10);
        //board[3, 1].GetComponent<Renderer>().material.color = Color.green;
        board[3, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(3, 1, 11);
        //board[4, 1].GetComponent<Renderer>().material.color = Color.green;
        board[4, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(4, 1, 12);
        //board[5, 1].GetComponent<Renderer>().material.color = Color.green;
        board[5, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(5, 1, 13);
        //board[6, 1].GetComponent<Renderer>().material.color = Color.green;
        board[6, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(6, 1, 14);
        //board[7, 1].GetComponent<Renderer>().material.color = Color.green;
        board[7, 1].GetComponent<TileInformation>().setToFriendly();
        addToFriendlies(7, 1, 15);

    }

    private void addToEnemies(int x, int z, int pieceNum)
    {
        enemiesInfo newEnemy = new enemiesInfo();
        newEnemy.thePiece = allBlackPieces[pieceNum];
        newEnemy.enemyPos = new int[2];
        newEnemy.enemyPos[0] = x;
        newEnemy.enemyPos[1] = z;
        allEnemies.Add(newEnemy);
    }

    private void addToFriendlies(int x, int z, int pieceNum)
    {
        friendliesInfo newFriendly = new friendliesInfo();
        newFriendly.thePiece = allWhitePieces[pieceNum];
        newFriendly.friendlyPos = new int[2];
        newFriendly.friendlyPos[0] = x;
        newFriendly.friendlyPos[1] = z;
        allFriendlies.Add(newFriendly);
    }

    public void movePieceTile(int x, int z, bool isWhite, int pieceNumber, Color oldTileColour)
    {
        if (isWhite)
        {
            board[allFriendlies[pieceNumber].friendlyPos[0], allFriendlies[pieceNumber].friendlyPos[1]].GetComponent<Renderer>().material.color = oldTileColour;
            board[x,z].GetComponent<Renderer>().material.color = Color.green;
            allFriendlies[pieceNumber].friendlyPos[0] = x;
            allFriendlies[pieceNumber].friendlyPos[1] = z;
        }
        else
        {
            board[allEnemies[pieceNumber].enemyPos[0], allEnemies[pieceNumber].enemyPos[1]].GetComponent<Renderer>().material.color = oldTileColour;
            board[x, z].GetComponent<Renderer>().material.color = Color.red;
            allEnemies[pieceNumber].enemyPos[0] = x;
            allEnemies[pieceNumber].enemyPos[1] = z;
        }

    }

    //private void spawnEnemy()
    //{
    //    //int x = Random.Range(0, 7);
    //    //int z = Random.Range(0, 7);
    //    int x = 4;
    //    int z = 3;
    //    bool hasSpawned = false;

    //    theEnemieInfo.Add(gameObject.AddComponent<enemiesInfo>());

    //    while (hasSpawned == false)
    //    {
    //        if (board[x, z].gameObject.GetComponent<TileInformation>().getDescription() != TileInformation.description.PlayerTile)
    //        {
    //            board[x, z].gameObject.GetComponent<Renderer>().material.color = Color.red;
    //            board[x, z].gameObject.GetComponent<TileInformation>().setToEnemy();
    //            theEnemieInfo[theEnemieInfo.Count - 1].setEnemyPos(x, z);
    //            hasSpawned = true;
    //        }
    //    }
    //    hasSpawned = false;
    //}

    private void setPlayerTile()
    {
        board[playerPosition[0], playerPosition[1]].GetComponent<Renderer>().material.color = playerTileColor;
        board[playerPosition[0], playerPosition[1]].GetComponent<TileInformation>().setToPlayer();
        playerPieceObject.transform.position = new Vector3(board[playerPosition[0], playerPosition[1]].transform.position.x, board[playerPosition[0], playerPosition[1]].transform.position.y + 1f, board[playerPosition[0], playerPosition[1]].transform.position.z);
    }

    //private void setEnemyTile()
    //{
    //    for (int i = 0; i < theEnemieInfo.Count; i++)
    //    {
    //        board[theEnemieInfo[i].enemyPos[0], theEnemieInfo[i].enemyPos[1]].GetComponent<Renderer>().material.color = Color.red;
    //        enemyPieceObject.transform.position = new Vector3(board[theEnemieInfo[0].enemyPos[0], theEnemieInfo[0].enemyPos[1]].transform.position.x, board[playerPosition[0], playerPosition[1]].transform.position.y + 1f, board[theEnemieInfo[0].enemyPos[0], theEnemieInfo[0].enemyPos[1]].transform.position.z);
    //    }
    //    //board[theEnemieInfo.enemyPos[0], theEnemieInfo.enemyPos[1]].GetComponent<TileInformation>().setToEnemy();
    //}

    //What moves can the player make
    private void checkWhichTiles()
    {
        playerInfo.pieceType thePiece = thePlayer.getPiece();

        if(thePiece == playerInfo.pieceType.pawn)
        {
            movesForPawn();
        }

        if (thePiece == playerInfo.pieceType.knight)
        {
            movesForKnight();
        }

        if (thePiece == playerInfo.pieceType.bishop)
        {
            movesForBishop();
        }

        if (thePiece == playerInfo.pieceType.rook)
        {
            movesForRook();
        }

        if (thePiece == playerInfo.pieceType.queen)
        {
            movesForQueen();
        }


    }

    private void movesForPawn()
    {

        if (isFirstMove)
        {
            if (checkIfExists(playerPosition[0], playerPosition[1] + 1, "N"))
            {
                board[playerPosition[0], playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] + 1].GetComponent<Renderer>().material.color = availableTileColor;
            }
            if (checkIfExists(playerPosition[0], playerPosition[1] + 2, "N"))
            {
                board[playerPosition[0], playerPosition[1] + 2].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] + 2].GetComponent<Renderer>().material.color = availableTileColor;
            }
            isFirstMove = false;
        }

        if (checkIfExists(playerPosition[0], playerPosition[1] + 1, "N"))
        {
            board[playerPosition[0], playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0], playerPosition[1] + 1].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] + 1, playerPosition[1] + 1, "NE"))
        {
            board[playerPosition[0] + 1, playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
        }


        if (checkIfExists(playerPosition[0] - 1, playerPosition[1] + 1, "NW"))
        {
            board[playerPosition[0] - 1, playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
        }

    }

    private void movesForKnight()
    {
        if (checkIfExists(playerPosition[0] + 1, playerPosition[1] - 2, "N"))
        {
            board[playerPosition[0] + 1, playerPosition[1] - 2].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] + 1, playerPosition[1] - 2].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] - 1, playerPosition[1] - 2, "N"))
        {
            board[playerPosition[0] - 1, playerPosition[1] - 2].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] - 1, playerPosition[1] - 2].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] + 2, playerPosition[1] - 1, "E"))
        {
            board[playerPosition[0] + 2, playerPosition[1] - 1].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] + 2, playerPosition[1] - 1].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] + 2, playerPosition[1] + 1, "E"))
        {
            board[playerPosition[0] + 2, playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] + 2, playerPosition[1] + 1].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] + 1, playerPosition[1] + 2, "S"))
        {
            board[playerPosition[0] + 1, playerPosition[1] + 2].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] + 1, playerPosition[1] + 2].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] - 1, playerPosition[1] + 2, "S"))
        {
            board[playerPosition[0] - 1, playerPosition[1] + 2].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] - 1, playerPosition[1] + 2].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] - 2, playerPosition[1] + 1, "W"))
        {
            board[playerPosition[0] - 2, playerPosition[1] + 1].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] - 2, playerPosition[1] + 1].GetComponent<Renderer>().material.color = availableTileColor;
        }

        if (checkIfExists(playerPosition[0] - 2, playerPosition[1] - 1, "W"))
        {
            board[playerPosition[0] - 2, playerPosition[1] - 1].GetComponent<TileInformation>().setToAvailable();
            board[playerPosition[0] - 2, playerPosition[1] - 1].GetComponent<Renderer>().material.color = availableTileColor;
        }
    }

    private void movesForBishop()
    {

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1] - i, "N"))
            {
                board[playerPosition[0] - i, playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1] - i, "E"))
            {
                board[playerPosition[0] + i, playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1] + i, "S"))
            {
                board[playerPosition[0] - i, playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1] + i, "W"))
            {
                board[playerPosition[0] + i, playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }
    }

    private void movesForRook()
    {
        for(int i = 0; i<=7; i++)
        {
            if (checkIfExists(playerPosition[0], playerPosition[1] - i, "N"))
            {
                board[playerPosition[0], playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1], "E"))
            {
                board[playerPosition[0] + i, playerPosition[1]].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1]].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0], playerPosition[1] + i, "S"))
            {
                board[playerPosition[0], playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1], "W"))
            {
                board[playerPosition[0] - i, playerPosition[1]].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1]].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }
    }

    private void movesForQueen()
    {
        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1] - i, "N"))
            {
                board[playerPosition[0] - i, playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1] - i, "E"))
            {
                board[playerPosition[0] + i, playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1] + i, "S"))
            {
                board[playerPosition[0] - i, playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1] + i, "W"))
            {
                board[playerPosition[0] + i, playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0], playerPosition[1] - i, "N"))
            {
                board[playerPosition[0], playerPosition[1] - i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] - i].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] + i, playerPosition[1], "E"))
            {
                board[playerPosition[0] + i, playerPosition[1]].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] + i, playerPosition[1]].GetComponent<Renderer>().material.color = availableTileColor;
            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0], playerPosition[1] + i, "S"))
            {
                board[playerPosition[0], playerPosition[1] + i].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0], playerPosition[1] + i].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }

        for (int i = 0; i <= 7; i++)
        {
            if (checkIfExists(playerPosition[0] - i, playerPosition[1], "W"))
            {
                board[playerPosition[0] - i, playerPosition[1]].GetComponent<TileInformation>().setToAvailable();
                board[playerPosition[0] - i, playerPosition[1]].GetComponent<Renderer>().material.color = availableTileColor;

            }
        }
    }

    private bool checkIfExists(int x, int z, string direction)
    {
        if (z >= 0 && z < boardZ && x >= 0 && x < boardX) return true;
        return false;
    }

    private void makeBoard(int x, int z)
    {
        for(int i = 0; i < x; i++)
        {
            for (int ij = 0; ij < z; ij++)
            {
                Vector3 TilePosition = new Vector3(1f + (i*2) + offsetX, 0.1f + offsetY, 1f + (ij*2) + offsetZ);
                Quaternion TileRotation = defaultTileWhite.transform.rotation;
                if (isWhite)
                {
                    board[i, ij] = Instantiate(defaultTileBlack, TilePosition, TileRotation);
                    board[i, ij].transform.parent = TilesParent;
                    board[i, ij].gameObject.GetComponent<TileInformation>().setTilePos(i, ij);
                    if(ij != 7)
                    {
                        isWhite = false;
                    }
                }
                else
                {
                    board[i, ij] = Instantiate(defaultTileWhite, TilePosition, TileRotation);
                    board[i, ij].transform.parent = TilesParent;
                    board[i, ij].gameObject.GetComponent<TileInformation>().setTilePos(i, ij);
                    if (ij != 7)
                    {
                        isWhite = true;
                    }
                }
            }
        }
    }

    public void movePlayer(int[] pos)
    {
        playerPosition[0] = pos[0];
        playerPosition[1] = pos[1];
        playerPieceObject.transform.position = new Vector3(board[playerPosition[0], playerPosition[1]].transform.position.x, board[playerPosition[0], playerPosition[1]].transform.position.y + 1f, board[playerPosition[0], playerPosition[1]].transform.position.z);
        updateBoard();
    }

    //public void moveEnemy()
    //{
    //    for (int i = 0; i < theEnemieInfo.Count; i++)
    //    {
    //        int rng = Random.Range(1, 5);
    //        if (rng == 1)
    //        {
    //            if (checkIfExists(theEnemieInfo[i].enemyPos[0], theEnemieInfo[i].enemyPos[1] - 1, "N") && (theEnemieInfo[i].enemyPos[0] != playerPosition[0] && theEnemieInfo[i].enemyPos[1] - 1 != playerPosition[1]))
    //            {
    //                theEnemieInfo[i].enemyPos[1]--;
    //            }
    //        }

    //        if (rng == 2)
    //        {
    //            if (checkIfExists(theEnemieInfo[i].enemyPos[0] - 1, theEnemieInfo[i].enemyPos[1], "N") && (theEnemieInfo[i].enemyPos[0] != playerPosition[0] - 1 && theEnemieInfo[i].enemyPos[1] != playerPosition[1]))
    //            {
    //                theEnemieInfo[i].enemyPos[0]--;
    //            }
    //        }

    //        if (rng == 3)
    //        {
    //            if (checkIfExists(theEnemieInfo[i].enemyPos[0], theEnemieInfo[i].enemyPos[1] + 1, "N") && (theEnemieInfo[i].enemyPos[0] != playerPosition[0] && theEnemieInfo[i].enemyPos[1] + 1 != playerPosition[1]))
    //            {
    //                theEnemieInfo[i].enemyPos[1]++;
    //            }
    //        }

    //        if (rng == 4)
    //        {
    //            if (checkIfExists(theEnemieInfo[i].enemyPos[0] + 1, theEnemieInfo[i].enemyPos[1], "N") && (theEnemieInfo[i].enemyPos[0] != playerPosition[0] + 1 && theEnemieInfo[i].enemyPos[1] != playerPosition[1]))
    //            {
    //                theEnemieInfo[i].enemyPos[0]++;
    //            }
    //        }

    //        enemyPieceObject.transform.position = new Vector3(board[theEnemieInfo[0].enemyPos[0], theEnemieInfo[0].enemyPos[1]].transform.position.x, board[playerPosition[0], playerPosition[1]].transform.position.y + 1f, board[theEnemieInfo[0].enemyPos[0], theEnemieInfo[0].enemyPos[1]].transform.position.z);
    //    }

    //}
    private void updateBoard()
    {
        clearBoard();
        checkIfPlayerOnEnemy();
        checkIfPlayerOnFriendly();
        setEnemyTiles();
        setFriendlyTiles();
        setPlayerTile();
        checkWhichTiles();
        //moveEnemy();
        //setEnemyTile();
        checkIfBothEnemy();
        checkIfBothFriendly();
        setPlayerTile();


    }

    private void checkIfPlayerOnEnemy()
    {
        foreach (enemiesInfo enemy in allEnemies)
        {
            if(playerPosition[0] == enemy.enemyPos[0] && playerPosition[1] == enemy.enemyPos[1])
            {
                enemy.thePiece.SetActive(false);
                enemyToRemove = enemy;
                Debug.Log("on enemy");
            }   
        }
        allEnemies.Remove(enemyToRemove);
    }

    private void checkIfPlayerOnFriendly()
    {
        foreach (friendliesInfo friend in allFriendlies)
        {
            if (playerPosition[0] == friend.friendlyPos[0] && playerPosition[1] == friend.friendlyPos[1])
            {
                //Debug.Log("On friend");
            }
        }
    }

    private void setEnemyTiles()
    {
        foreach(enemiesInfo enemy in allEnemies)
        {
            board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<Renderer>().material.color = Color.red;
            board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<TileInformation>().setToEnemy();
        }
    }

    private void setFriendlyTiles()
    {
        foreach (friendliesInfo friend in allFriendlies)
        {
            //board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<Renderer>().material.color = Color.green;
            board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<TileInformation>().setToFriendly();
        }
    }

    private void checkIfBothEnemy()
    {
        foreach (enemiesInfo enemy in allEnemies)
        {
            if (board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<TileInformation>().getDescription() == TileInformation.description.AvailableTile)
            {
                if(thePlayer.playerPiece == playerInfo.pieceType.pawn && board[playerPosition[0], playerPosition[1] + 1] == board[enemy.enemyPos[0], enemy.enemyPos[1]])
                {
                    board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<TileInformation>().setToEnemy();
                    board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<Renderer>().material.color = Color.red;
                }
                else
                {
                    board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<TileInformation>().setToAvailableEnemy();
                    board[enemy.enemyPos[0], enemy.enemyPos[1]].GetComponent<Renderer>().material.color = Color.magenta;
                }
            }
        }
    }

    private void checkIfBothFriendly()
    {
        foreach (friendliesInfo friend in allFriendlies)
        {
            if (board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<TileInformation>().getDescription() == TileInformation.description.AvailableTile)
            {
                if (thePlayer.playerPiece == playerInfo.pieceType.pawn && board[playerPosition[0], playerPosition[1] + 1] == board[friend.friendlyPos[0], friend.friendlyPos[1]])
                {
                    board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<TileInformation>().setToFriendly();
                    board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<Renderer>().material.color = Color.green;
                }
                else
                {
                    board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<TileInformation>().setToAvailableFriendly();
                    board[friend.friendlyPos[0], friend.friendlyPos[1]].GetComponent<Renderer>().material.color = Color.cyan;
                }
            }
        }
    }


    private void clearBoard()
    {
        for (int i = 0; i < boardX; i++)
        {
            for (int ij = 0; ij < boardZ; ij++)
            {
                board[i, ij].GetComponent<TileInformation>().setToDefault();
                board[i, ij].GetComponent<Renderer>().material.color = board[i, ij].GetComponent<TileInformation>().getColor();
            }
        }
    }

    //public void enemyTaken(int[] pos)
    //{
    //    thePlayer.addTake();
    //    enemiesInfo enemyToRemove = gameObject.AddComponent<enemiesInfo>();
    //    foreach(enemiesInfo enemy in theEnemieInfo)
    //    {
    //        if(enemy.enemyPos[0] == pos[0] && enemy.enemyPos[1] == pos[1])
    //        {
    //            enemyToRemove = enemy;
    //        }
    //    }
    //    theEnemieInfo.Remove(enemyToRemove);
    //    spawnEnemy();
    //}


}
