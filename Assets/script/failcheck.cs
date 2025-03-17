using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class failcheck : MonoBehaviour
{
    public bool fall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BuildObj")
        {
            fall = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "BuildObj")
        {
            fall = false;
        }
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
