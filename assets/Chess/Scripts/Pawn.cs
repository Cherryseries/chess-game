using Chess.Scripts.Core;
using UnityEngine;

public class Pawn : ChessPlayerPlacementHandler
{
    int row1, col1;
    public static Pawn instance;
    public bool SelectedPawn = true;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update

    private void Update()
    {
        row = gameObject.GetComponent<ChessPlayerPlacementHandler>().row;
        column = gameObject.GetComponent<ChessPlayerPlacementHandler>().column;

        gameObject.transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }
    private void OnMouseDown()
    {
        GameManager.Instance.selectedPiece = this.gameObject;
        ChessBoardPlacementHandler.Instance.ClearHighlights();

        if (gameObject.CompareTag("Black")) 
        {
            row1 = row;
            col1 = column;
            ++row1;
            Obstracles.instance.Obstraclepos(row1,col1);
            if(Obstracles.instance.isPossible == true) 
            {
                ChessBoardPlacementHandler.Instance.Highlight(row1, col1);
                SelectedPawn = true;
            }

        }

        if (gameObject.CompareTag("White"))
        {
            row1 = row;
            col1 = column;
            ChessBoardPlacementHandler.Instance.Highlight(--row1, col1);
            SelectedPawn = true;
        }
       
    }
}
