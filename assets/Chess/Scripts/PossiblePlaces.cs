using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossiblePlaces : MonoBehaviour
{
    private void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
       // Knight.Instance.moveKnight();
      //  Knight.Instance.isClicked = false;
      //  Bishop.instance.moveBishop();
    }
}
