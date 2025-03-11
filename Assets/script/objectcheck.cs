using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectcheck : MonoBehaviour
{
    // Start is called before the first frame update
    public bool placment;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BuildObj")
        {
                placment = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BuildObj")
        {
                placment = false;
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}