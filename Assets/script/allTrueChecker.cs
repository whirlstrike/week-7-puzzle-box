using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class allTrueChecker : MonoBehaviour
{
    public List<GameObject> objectcheck;
    public bool alltrue;
    public bool fall;
    //public string currentSceneName = SceneManager.GetActiveScene().name;
    // Start is called before the first frame update
    void Start()
    {
    }
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




    // Update is called once per frame
    void Update()
    {
        alltrue = true;

        foreach (GameObject obj in objectcheck) 
        {

            if(obj.GetComponent<objectcheck>().placment== false)
            {
                alltrue = false;
            }

            if(alltrue == true)
            {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
