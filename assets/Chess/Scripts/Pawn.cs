using Chess.Scripts.Core;
using UnityEngine;

public class Pawn : ChessPlayerPlacementHandler
{

    public static Pawn instance;
    private bool isSelected = false;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update

    private void Update()
    {
        if (!isSelected)
        {
            gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
        }
    }
    private void OnMouseDown()
    { 
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        if(!isSelected) 
        {
            ChessBoardPlacementHandler.Instance.Highlight(++row, column);
            isSelected = true;
        }
    }

    public void MovePawn() 
    {
        this.gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
        Debug.Log(row + "," + column);
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        Debug.Log("Pawn moved");
        isSelected = false;
    }

}
