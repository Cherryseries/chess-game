using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPlayerPlacementHandler
{
    private bool isSelected = false;

    int row1, col1;
    private void Update()
    {

        gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private void OnMouseDown()
    {
        if (!isSelected)
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
            isSelected = true;
        }
    }

    private void UpRowPoss()
    {
        try
        {
            row1 = row;
            col1 = column;
            ChessBoardPlacementHandler.Instance.Highlight(++row1, col1);
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
            ChessBoardPlacementHandler.Instance.Highlight(--row1, col1);
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
            ChessBoardPlacementHandler.Instance.Highlight(row1, ++col1);
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
            ChessBoardPlacementHandler.Instance.Highlight(row1, --col1);
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
            row1 = row;
            col1 = column;
            ChessBoardPlacementHandler.Instance.Highlight(++row1, ++col1);

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
             row1 = row;
             col1 = column;
             ChessBoardPlacementHandler.Instance.Highlight(--row1, ++col1);
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
            row1 = row;
            col1 = column;
            ChessBoardPlacementHandler.Instance.Highlight(++row1, --col1);
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
             row1 = row;
             col1 = column;
             ChessBoardPlacementHandler.Instance.Highlight(--row1, --col1);

        }
        catch (NullReferenceException e)
        {
            Debug.Log(" may be out of bound or this error" + e.Message);
        }
    }

    public void MoveKing()
    {
     //   this.gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
        Debug.Log(row + "," + column);
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        Debug.Log("Pawn moved");
        isSelected = false;
    }

}
