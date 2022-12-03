using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour
{
    int lengthOfBoard = 8;

    public GameObject boardTiles;


    GameObject[,] tilesArray = new GameObject[8, 8];

    // Start is called before the first frame update
    void Start()
    {
        //BoardTilesCreated();       
        for (int i = 0; i < lengthOfBoard; i++)
        {
            for (int j = 0; j < lengthOfBoard; j++)
            {
                tilesArray[i, j] = Instantiate(boardTiles, new Vector3(i, 4, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
