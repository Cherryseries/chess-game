using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstracles : MonoBehaviour
{
    [SerializeField] GameObject[] ChessPieces;
    int row, col;
    public static Obstracles instance;

    public bool isPossible;
    private void Awake()
    {
        instance = this;
    }
    public void Obstraclepos(int x,int y)
    {
        for (int i = 0; i < ChessPieces.Length; i++)
        {
            row = ChessPieces[i].GetComponent<ChessPlayerPlacementHandler>().row;
            col = ChessPieces[i].GetComponent<ChessPlayerPlacementHandler>().column;


            if (row == x && col == y)
            {
                isPossible = false;
                Debug.Log("obstracle name" + ChessPieces[i].name);
                Debug.Log("occupied positions" + x + "," + y);
                Debug.Log(isPossible);
                if (ChessPieces[i].CompareTag("Black"))
                {
                    Debug.Log("black");
                }

                if (ChessPieces[i].CompareTag("White"))
                {
                    Debug.Log("white");
                }
            }

            else 
            {
                isPossible = true;
                Debug.Log(" no obstracle name");
                Debug.Log("free positions" + x + "," + y);
                Debug.Log(isPossible);
            }
        }
    }
}
