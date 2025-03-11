using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragDropCard : MonoBehaviour
{

    Collider2D ThisColider;
    Camera Cam;
    bool IsBeingDragged = false;
    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
        ThisColider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) 
        {
        Collider2D col = Physics2D.OverlapPoint(mousePos);
            if (col == ThisColider)
            {
                transform.position = mousePos;
            }
            
        }
     
    }

}