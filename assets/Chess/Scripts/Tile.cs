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
        GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().row = rowNum;
        GameManager.Instance.selectedPiece.GetComponent<ChessPlayerPlacementHandler>().column = colNum;
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        Debug.Log("tile :"+rowNum+colNum);
    }
}
