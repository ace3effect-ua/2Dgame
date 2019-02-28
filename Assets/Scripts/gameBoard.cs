using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBoard : MonoBehaviour
{
    public Piece[,] pieces = new Piece[5, 8];
    public GameObject pennyPrefab;
    public GameObject dimePrefab;

    void Start(){
        makeBoard();
    }

    void makeBoard(){
        //make pennies
        for(int y = 0; y < 1; y++){
            for(int x = 0; x < 4; x++){
                //generate pennies
                makePiece(x,y);
            }
        }
    }

    void makePiece(int x, int y){
        
        GameObject go = Instantiate(pennyPrefab) as GameObject;
        go.transform.SetParent(transform);
        Piece p = go.GetComponent<Piece>();
        pieces[x,y] = p;
        //placePiece(p, x, y);
    }

    //void placePiece(Piece p, int x, int y){
        //p.transform.position = 
    //}
}
