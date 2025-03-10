using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragDropCard : MonoBehaviour
{
    private bool isDragging;

    public void OnMouseDown()
    {
        isDragging = true;
    }
    public void OnMouseUp()
    {
        isDragging = false;
    }
    public void OnMouseDrag()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.Translate(mousePosition);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collision " + other.name);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}