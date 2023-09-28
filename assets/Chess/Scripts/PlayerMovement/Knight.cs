using Chess.Scripts.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPlayerPlacementHandler
{
    public bool isClicked = false;

    public static Knight Instance;

    private void Awake()
    {
        Instance = this;
    }


    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        Lpos();
    }

    private void Update()
    {
        //transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private void Lpos()
    {
        if(!isClicked) 
        {
            try
            {
                if ((row <= 7 && row >= 0) && (column <= 7 && column >= 0))
                {
                    // one chance
                    for (int i = 0; i < 2; i++)
                    {
                        ChessBoardPlacementHandler.Instance.Highlight(++row, column);
                    }
                    ChessBoardPlacementHandler.Instance.Highlight(row, --column);
                    // second chance
                    // After for loop
                    ChessBoardPlacementHandler.Instance.Highlight(row, 2 + column);
                    isClicked = true;
                }
            }

            catch (NullReferenceException e)
            {
                Debug.Log(" may be out of bound or this error" + e.Message);
            }
        }
    }

    public void moveKnight()
    {
        this.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
}
