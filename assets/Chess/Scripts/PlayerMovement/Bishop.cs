using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPlayerPlacementHandler
{
    public int row1, col1;

    private void Update()
    {
        row = GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().row;
        column = GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().column;
        transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private  void  OnMouseDown()
    {
        //if(!isMoving) { }
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        GameManager.Instance.selectedPiece = this.gameObject;
        RightDiagonals();
        RightDownDiagonals();
        LeftDiagonals();
        LeftDownDiagonals();
    }
    private void RightDiagonals()
    {
        try
        {
            
                if ((column <= 7 && column >= 0) && (row <= 7 && row >= 0))
                {
                    row1 = row;
                    col1 = column;
                    for (int i = col1; i <= 7; i++)
                    {
                    ++row1;
                    ++col1;
                    ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    Debug.Log("possible positions"+row1 + " " + col1);
                    }
                } 
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void RightDownDiagonals()
    {
        try
        {

            if ((column <= 7 && column >= 0) && (row <= 7 && row >= 0))
            {
                row1 = row;
                col1 = column;
                for (int i = col1; i <= 7; i++)
                {
                    --row1;
                    ++col1;
                    ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    Debug.Log("possible positions" + row1 + " " + col1);
                }
            }
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void LeftDiagonals()
    {
        try
        {
            if ((column <= 7 && column >= 0) && (row <= 7 && row >= 0))
            {
                row1 = row;
                col1 = column;
                for (int i = col1; i >= 0; i--)
                {
                    ++row1;
                    --col1;
                    ChessBoardPlacementHandler.Instance.Highlight(row1,col1);
                  //  Obstracles.instance.Obstraclepos(row1, col1);
                }
            }
        }
        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void LeftDownDiagonals()
    {
        try
        {
            if ((column <= 7 && column >= 0) && (row <= 7 && row >= 0))
            {
                row1 = row;
                col1 = column;
                for (int i = col1; i >= 0; i--)
                {
                    --row1;
                    --col1;
                    ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    //  Obstracles.instance.Obstraclepos(row1, col1);
                }
            }
        }
        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }



    public void moveBishop()
    {
        this.gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row1, col1).transform.position;
    }
}