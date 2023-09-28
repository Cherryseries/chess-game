using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracles : MonoBehaviour
{
    [SerializeField] GameObject[] ChessPieces;
    int row, col;
    public static Obstracles instance;

    public GameObject selectedone;

    public int obstracleRow;
    public int obstracleCol;

    public bool isPossible;
    private void Awake()
    {
        instance = this;
    }
    public bool Obstraclepos(int x,int y)
    {
        for(int i = 0; i < ChessPieces.Length; i++) 
        {
            row = ChessPieces[i].GetComponent<ChessPlayerPlacementHandler>().row;
            col = ChessPieces[i].GetComponent<ChessPlayerPlacementHandler>().column;
            if(row == x && col == y)
            {
                Debug.Log("occupied positions"+x + "," + y);
                Debug.Log(isPossible);
                isPossible = false;
            }
        }
        return isPossible;  
    }
}
