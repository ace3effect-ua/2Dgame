using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBoard : MonoBehaviour
{
    public Piece[,] pieces = new Piece[5, 8];
    public GameObject pennyPrefab;
    public GameObject dimePrefab;

    //public GameObject pennyKingPinPrefab;
    //public GameObject dimeKingPinPrefab;

    private Vector3 boardOffset = new Vector3(-2.5f, -2.5f, 0.0f);
    private Vector3 dimeOffset = new Vector3(-1.5f, 4.5f, -7.0f); // just for placing the dimes

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
        //make dimes
        for(int y = 7; y > 6; y--){
            for(int x = 0; x < 4; x++){
                //generate dimes
                makeDime(x,y);
            }
        }
    }

    void makePiece(int x, int y){

        //bool isPenny = (y > 1) ? false : true;weird if statement
        GameObject go = Instantiate(pennyPrefab)as GameObject;
        go.transform.SetParent(transform);
        Piece p = go.GetComponent<Piece>();
        pieces[x,y] = p;
        placePiece(p, x, y);
    }
    void makeDime(int x, int y){

        //bool isPenny = (y > 1) ? false : true; weird if statement
        GameObject go = Instantiate(dimePrefab) as GameObject;
        go.transform.SetParent(transform);
        Piece p = go.GetComponent<Piece>();
        pieces[x,y] = p;
        placeDime(p, x, y);
    }

    void placePiece(Piece p, int x, int y){
        p.transform.position = (Vector3.right * x) + (Vector3.forward *y) + boardOffset;
    }
    void placeDime(Piece p, int x, int y){
        p.transform.position = (Vector3.right * x) + (Vector3.forward *y) + dimeOffset;
    }
}
