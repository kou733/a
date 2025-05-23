using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PieceSize {small = 0,Medium =1, large = 2}

public class Piece : MonoBehaviour
{
    public int playerId; 
    public PieceSize size;


    public void SetPiece(int player, PieceSize pieceSize)
    {
        this.playerId = player;
        size = pieceSize;
    }
}