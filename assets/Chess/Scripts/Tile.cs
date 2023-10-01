using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public static Tile Instance;
    private void Awake()
    {
        Instance = this;
    }
    [SerializeField] private int rowNum;
    [SerializeField] private int colNum;

    public void OnMouseDown()
    {      
        if(gameObject.transform.childCount > 0) 
        {
            GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().row = rowNum;
            GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().column = colNum;
            ChessBoardPlacementHandler.Instance.ClearHighlights();
           // King.Instance.isSelected = false;
           // Pawn.instance.SelectedPawn = false;
           // Knight.Instance.isClicked = false;
           // Debug.Log("tile :" + rowNum + colNum);
        }
    }
}
