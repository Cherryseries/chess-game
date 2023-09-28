using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Queen : ChessPlayerPlacementHandler
{
    public int row1, col1;

private void OnMouseDown()
{
    ChessBoardPlacementHandler.Instance.ClearHighlights();
    GameManager.Instance.selectedPiece = this.gameObject;
    UpRowPoss();
    DownRowPoss();
    Rightcolposs();
    Leftcolposs();
    RightDiagonals();
    LeftDiagonals();
    RightDownDiagonals();
    LeftDownDiagonals();
}

    private void Update()
    {
        row = GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().row ;
        column= GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().column;
        row1 = row ;
        col1 = column;
        transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;

    }

    private void UpRowPoss()
    {
        try
        {
            row1 = row;
            col1 = column;
            if (row1 <= 7 && row1 >= 0)
            {
                for (int i = row1; i <= 7; i++)
                {
                    ChessBoardPlacementHandler.Instance.Highlight(++row1, col1);
                }
            }
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void DownRowPoss()
    {
        try
        {
            row1 = row;
            col1 = column;
            if (row1 <= 7 && row1 >= 0)
            {
                for (int i = row1; i <= 7; i++)
                {
                    ChessBoardPlacementHandler.Instance.Highlight(--row1, col1);
                    Debug.Log(row1+column);
                }
            }
        }
        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void Rightcolposs()
    {
        try
        {
            row1 = row;
            col1 = column;
            if (col1 <= 7 && col1 >= 0)
            {
                for (int j = col1; j <= 7; j++)
                {
                    ChessBoardPlacementHandler.Instance.Highlight(row1, ++col1);
                }
            }
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    private void Leftcolposs()
    {
        try
        {
            row1 = row;
            col1 = column;
            if (col1 <= 7 && col1 >= 0)
            {
                for (int j = 1; j <= 7; j++)
                {
                    ChessBoardPlacementHandler.Instance.Highlight(row1, --col1);
                    Debug.Log("Rook left possiblilities :" + row1 + "," + col1);
                }
            }
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
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
                    Debug.Log("possible positions" + row1 + " " + col1);
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

}
