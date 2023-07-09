using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{

    [SerializeField] TileManager theTileManager;
    [SerializeField] GameObject TurnControl;
    //public timerManager theTimer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray;
        RaycastHit hit;

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (TurnControl.GetComponent<TurnControls>().PlayerHasControl)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (hit.collider.tag == "Tile")
                    {
                        if(hit.collider.gameObject.GetComponent<TileInformation>().getDescription() == TileInformation.description.AvailableTile)
                        {
                            theTileManager.movePlayer(hit.collider.gameObject.GetComponent<TileInformation>().getPos());
                        }
                        if (hit.collider.gameObject.GetComponent<TileInformation>().getDescription() == TileInformation.description.AvailableEnemy)
                        {
                            theTileManager.movePlayer(hit.collider.gameObject.GetComponent<TileInformation>().getPos());
                            //theTileManager.enemyTaken(hit.collider.gameObject.GetComponent<TileInformation>().getPos());
                        }
                        TurnControl.GetComponent<TurnControls>().StartEnemyTurn();
                    }

                }
            }
        }
    }
}
