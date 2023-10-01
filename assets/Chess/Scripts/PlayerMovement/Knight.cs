using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPlayerPlacementHandler
{
    //public bool isClicked = false;

    public static Knight Instance;

    private void Awake()
    {
        Instance = this;
    }

    int row1, col1;

    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        GameManager.Instance.selectedPiece = this.gameObject;
        Lpos();
    }

    private void Update()
    {
        row = gameObject.GetComponent<ChessPlayerPlacementHandler>().row;
        column = gameObject.GetComponent<ChessPlayerPlacementHandler>().column;

        gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private void Lpos()
    {
       // if(!isClicked) 
        
            try
            {
                row1 = row;
                col1 = column;
                if ((row1 <= 7 && row1 >= 0) && (col1 <= 7 && col1 >= 0))
                {
                    
                    // one chance
                    for (int i = 0; i < 2; i++)
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(++row1, col1);
                    }
                    --col1;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if (Obstracles.instance.isPossible == true)
                    {
                    ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                // second chance
                // After for loop
                    col1+=2;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if (Obstracles.instance.isPossible == true)
                    {
                    ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                   // isClicked = true;
                }
            }

            catch (NullReferenceException e)
            {
                Debug.Log(" may be out of bound or this error" + e.Message);
            }
        
    }

}
