using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Board : MonoBehaviour
{
    int lengthOfBoard = 8;

    public GameObject boardTiles;
    public GameObject darkpawns;
    public GameObject lightpawns;

    public GameObject darkknight;
    public GameObject lightknight;

    public GameObject darkbishop;
    public GameObject lightbishop;

    public GameObject darkking;
    public GameObject lightking;

    public GameObject darkQueen;
    public GameObject lightQueen;

    public GameObject darkRook;
    public GameObject lightRook;




    GameObject[,] tilesArray = new GameObject[8, 8];
    GameObject[,] whiteArray = new GameObject[2, 8];
    GameObject[,] blackArray = new GameObject[2, 8];
    

    // Start is called before the first frame update
    void Start()
    {
        
        BoardTilesCreated();
        setStartPos();
    }

    void BoardTilesCreated()
    {
        for (int i = 0; i < lengthOfBoard; i++)
        {
            for (int j = 0; j < lengthOfBoard; j++)
            {
                tilesArray[i, j] = Instantiate(boardTiles, new Vector3(i, (float)0.01, j), Quaternion.identity);
                
            }
            Instantiate(darkpawns, new Vector3(i, 0, 6), Quaternion.identity);
            Instantiate(lightpawns, new Vector3(i, 0, 1), Quaternion.identity);
        }
    }

    void setStartPos() {
        int dz = 7, lz = 0;
        Instantiate(darkRook, new Vector3(7, 0, dz), Quaternion.identity);
        Instantiate(darkRook, new Vector3(0, 0, dz), Quaternion.identity);

        Instantiate(darkknight, new Vector3(1, 0, dz), Quaternion.identity);
        Instantiate(darkknight, new Vector3(6, 0, dz), Quaternion.identity);

        Instantiate(darkking, new Vector3(4, 0, dz), Quaternion.identity);
        Instantiate(darkQueen, new Vector3(3, 0, dz), Quaternion.identity);

        Instantiate(darkbishop, new Vector3(2, 0, dz), Quaternion.identity);
        Instantiate(darkbishop, new Vector3(5, 0, dz), Quaternion.identity);

        Instantiate(lightRook, new Vector3(0, 0, lz), Quaternion.identity);
        Instantiate(lightRook, new Vector3(7, 0, lz), Quaternion.identity);

        Instantiate(lightknight, new Vector3(1, 0, lz), Quaternion.identity);
        Instantiate(lightknight, new Vector3(6, 0, lz), Quaternion.identity);

        Instantiate(lightking, new Vector3(4, 0, lz), Quaternion.identity);
        Instantiate(lightQueen, new Vector3(3, 0, lz), Quaternion.identity);

        Instantiate(lightbishop, new Vector3(5, 0, lz), Quaternion.identity);
        Instantiate(lightbishop, new Vector3(2, 0, lz), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
