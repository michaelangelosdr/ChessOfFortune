using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers_Controllers;

public class WHITE_PIECE_IDLE_STATE : IState
{
    TileManager tilemanager;
    public WHITE_PIECE_IDLE_STATE(IManager t_manager,IManager manager, StateMachine machine) : base(manager, machine)
    { tilemanager = t_manager as TileManager; }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }

    public override States GetState()
    {
        return States.WHITE_PIECE_IDLE_STATE;
    }

    public override void Init()
    {
      //Setup scoring here.
    }

    RaycastHit hit;
    ChessTile selectedTile = null;
    public override void Run()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit, Mathf.Infinity,1<<8))
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (selectedTile == null)
                {
                    selectedTile = hit.collider.gameObject.GetComponent<ChessTile>().IsSelected(true);

                }
                else
                if (selectedTile != hit.collider.gameObject.GetComponent<ChessTile>())
                {
                    selectedTile.IsSelected(false);
                    selectedTile = hit.collider.gameObject.GetComponent<ChessTile>().IsSelected(true);
                }
         
               
            }               
        }
        
     
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
