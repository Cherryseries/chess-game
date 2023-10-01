using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPlayerPlacementHandler
{
   // public bool isSelected = false;

    public static King Instance;
    private void Awake()
    {
        Instance = this;
    }

    int row1, col1;
    private void Update()
    {
        row = gameObject.GetComponent<ChessPlayerPlacementHandler>().row;
        column = gameObject.GetComponent<ChessPlayerPlacementHandler>().column;

        gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private void OnMouseDown()
    {
 
       // if (!isSelected)
        
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
          //  isSelected = true;
        
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
}
