using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mappa_visibile : MonoBehaviour
{
    Scene m_Scene;
    string sceneName;

    public GameObject ObjectMappa;
    public GameObject puntino;
    public GameObject puntino_gaia;
    public GameObject puntino_prigione;


    void Start()
    {
        // Create a temporary reference to the current scene.
        Scene current_Scene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = current_Scene.name;
        print(sceneName);

        ObjectMappa.SetActive(false);
        puntino.SetActive(false);
        puntino_gaia.SetActive(false);
        puntino_prigione.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("m"))
        {
            ObjectMappa.SetActive(true);

            if (sceneName == "World_auro")
            {
                puntino.SetActive(true);
                puntino_gaia.SetActive(false);
                puntino_prigione.SetActive(false);
            }
            else if (sceneName == "Word Gaia")
            {
                puntino.SetActive(false);
                puntino_gaia.SetActive(true);
                puntino_prigione.SetActive(false);
            }
            else if (sceneName == "Prison")
            {
                puntino.SetActive(false);
                puntino_gaia.SetActive(false);
                puntino_prigione.SetActive(true);
            }
            else
            {
                print("niente");
            }

        }
        else
        {
            ObjectMappa.SetActive(false);
        }
    }
}
