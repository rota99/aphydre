using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mappa_visibile : MonoBehaviour
{
    //Scene m_Scene;
    //string sceneName;

    public GameObject ObjectMappa;


    void Start()
    {
        // Create a temporary reference to the current scene.
        string m_Scene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = m_Scene.name;
        print(sceneName);

        ObjectMappa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("m"))
        {
            ObjectMappa.SetActive(true);

            //if (sceneName == "Example 1")
            //{
                // Do something...
            //}
            //else if (sceneName == "Example 2")
            //{
                // Do something...
            //}
        }
        else
        {
            ObjectMappa.SetActive(false);
        }
    }
}
