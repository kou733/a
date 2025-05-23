using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Piece> stackedPieces = new List<Piece>();

    public void PlacePiece(Piece newPiece)
    {
    if(CanPlace(newPiece))
        {
            stackedPieces.Add(newPiece)
            newPiece.transform.position = this.transform.position;
        }
    }
    public bool CanPlace(Piece newPiece)
    {
        if (stackedPieces.Count == 0) return true;

        Piece top = stackedPieces[stackedPieces.Count - 1];
        return newPiece.size > top.size;
    }
    public piece GetTopPiece()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
