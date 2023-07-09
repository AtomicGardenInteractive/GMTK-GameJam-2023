using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesInfo
{
    public enum enemyPiece { pawn, knight, bishop, rook, queen }
    public int[] enemyPos;
    public bool taken = false;
    public GameObject thePiece;

    public int[] getEnemyPos()
    {
        return enemyPos;
    }

    public void setEnemyPos(int x, int z)
    {
        enemyPos = new int[2];
        enemyPos[0] = x;
        enemyPos[1] = z;
    }

    public void setTaken()
    {
        taken = true;
    }

}

public class friendliesInfo
{
    public enum friendlyPiece { pawn, knight, bishop, rook, queen }
    public int[] friendlyPos;
    public bool taken = false;
    public GameObject thePiece;
}
