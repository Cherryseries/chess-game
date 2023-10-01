using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPlayerPlacementHandler
{
    public int row1, col1;
    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        // Debug.Log("Rook position currect"+row+","+column);
        GameManager.Instance.selectedPiece = this.gameObject;
        UpRowPoss();
        DownRowPoss();
        Rightcolposs();
        Leftcolposs();
    }

    private void Update()
    {
        row = gameObject.GetComponent<ChessPlayerPlacementHandler>().row;
        column = gameObject.GetComponent<ChessPlayerPlacementHandler>().column;
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
                    ++row1;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if(Obstracles.instance.isPossible == true) 
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                    else 
                    {
                        break;
                    }
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
                for (int i = 0; i <= 7; i++)
                {
                    --row1;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if (Obstracles.instance.isPossible == true)
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                    else
                    {
                        break;
                    }
                    // Debug.Log(row1+","+col1);
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
                    ++col1;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if (Obstracles.instance.isPossible == true)
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                    else
                    {
                        break;
                    }
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
                    --col1;
                    Obstracles.instance.Obstraclepos(row1, col1);
                    if (Obstracles.instance.isPossible == true)
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                    }
                    else
                    {
                        break;
                    }
                    // Debug.Log("Rook left possiblilities :"+row1+","+col1);
                }
            }
        }

        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }
}
