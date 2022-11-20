using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieces : MonoBehaviour
{

    private string pieceColour;
    private int xCordinate;
    private int zCordinate;
    private string pieceType;
    bool startPositions = true;

    public void setPieceColour(string pieceColour) {
        pieceColour = this.pieceColour;
    }
    public string getPieceColour()
    {
        return pieceColour;
    }

    public void setZCordinate(int zCordinate)
    {
        zCordinate = this.zCordinate;
    }
    public int getZCordinate()
    {
        return zCordinate;
    }

    public void setXCordinate(int xCordinate)
    {
        xCordinate = this.xCordinate;
    }
    public int getXCordinate()
    {
        return xCordinate;
    }

    public void setPieceType(string pieceType)
    {
        pieceType = this.pieceType;
    }
    public string getPieceType()
    {
        return pieceType;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (startPositions == true) {
            startPositions = false;



            //transform.position = new Vector3(10, 0, 5);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
