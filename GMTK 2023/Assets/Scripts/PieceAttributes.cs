using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceAttributes : MonoBehaviour
{
    [SerializeField] private int x;
    [SerializeField] private int z;
    [SerializeField] private int number;
    [SerializeField] private bool isWhite;

    [SerializeField] private GameObject TileController;


    // Start is called before the first frame update
    void Start()
    {
        GoTo(x,z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoTo(int newx, int newz)
    {
        float tempx = -7 + (2 * newx) - (float)7.438332;
        float tempz = 5 + (2 * newz) - (float)48.50581;
        bool colourBlack = true;
        transform.position = new Vector3(tempx , (float)9.920979 -8, tempz );

        if( x%2 == 0)
        {
            if(z%2 == 0)
            {
                colourBlack = true;
            }
            else{
                colourBlack = false;
            }
        }
        else
        {
           if(z%2 == 0)
            {
                colourBlack = false;
            }
            else{
                colourBlack = true;
            } 
        }

        if (colourBlack)
        {
            TileController.GetComponent<TileManager>().movePieceTile(x,z, isWhite ,number, true);
        }
        else{
            TileController.GetComponent<TileManager>().movePieceTile(x,z, isWhite, number, false);
        }
        
    }
}
