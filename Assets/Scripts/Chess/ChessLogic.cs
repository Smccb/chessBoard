using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessLogic : MonoBehaviour
{
    string Name = "MyName";


    /* private Camera currentCamera;
     [SerializeField] private Material highlightTileMaterial;
     [SerializeField] private string selectableTag = "Selectable";
     [SerializeField] private Material defaulyMaterial;

     private Transform _selection;
    */
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()
    // {







    /*if (_selection != null)
    {
        var selectionsRenderer = _selection.GetComponent<Renderer>();
        selectionsRenderer.material = defaulyMaterial;
        _selection = null;
    }

    //RaycastHit info;
   // Ray ray = currentCamera.ScreenPointToRay(Input.mousePosition);
    //if (Physics.Raycast(ray, out info, 100, LayerMask.GetMask("boardTiles(Clone)"))) {


  //  }


    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit)) {
        var selection = hit.transform;
        var selectionsRenderer = selection.GetComponent<Renderer>();
        if (selection.CompareTag(selectableTag)) {
            if (selectionsRenderer != null)
            {
                selectionsRenderer.material = highlightTileMaterial;
            }
        }
    }*/
   //}

   /* void //Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                if (raycastHit.transform != null)
                {
                    //Our custom method. 
                    CurrentClickedGameObject(raycastHit.transform.gameObject);
                }
            }
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "somet$$anonymous$$ng")
        {
        }
    }



    }*/




}