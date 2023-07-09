using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInformation : MonoBehaviour
{
    [SerializeField] public enum description {EmptyTile, PlayerTile, AvailableTile, ChestTile, EnemyTile, AvailableEnemy, Friendly, AvailableFriendly }
    [SerializeField] private description TileDescription = description.EmptyTile;
    [SerializeField] private Color TileColor;
    [SerializeField] private int[] tilePos = new int[2];

    // Start is called before the first frame update

    public void setToPlayer()
    {
        TileDescription = description.PlayerTile;
    }
    public void setToAvailable()
    {
        TileDescription = description.AvailableTile;
    }

    public void setToEnemy()
    {
        TileDescription = description.EnemyTile;
    }

    public void setToAvailableEnemy()
    {
        TileDescription = description.AvailableEnemy;
    }

    public void setToDefault()
    {
        TileDescription = description.EmptyTile;
    }

    public void setToFriendly()
    {
        TileDescription = description.Friendly;
    }

    public void setToAvailableFriendly()
    {
        TileDescription = description.AvailableFriendly;
    }

    public void setColor(Color newColor)
    {
        TileColor = newColor;
    }

    public Color getColor()
    {
        return TileColor;
    }
    public description getDescription()
    {
        return TileDescription;
    }


    public void setTilePos(int x, int z)
    {
        tilePos = new int[2];
        tilePos[0] = x;
        tilePos[1] = z;
    }

    public int[] getPos()
    {
        return tilePos;
    }

}
