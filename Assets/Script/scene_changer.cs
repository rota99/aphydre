using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
    private GameObject posArrivo;
    private GameObject posUscita;
    private GameObject player;

    private string arrivo;
    private string uscita;

    //funzione che viene chiamata quando viene fatto il click sul pulsante "start"
    //passo come parametro il nome della scena verso cui voglio andare e poi
    //eseguo la funzione SceneManager.LoadScene() dove specifico il nome della scena da caricare
    public void changeMenuScene(string sceneName) {
      SceneManager.LoadScene(sceneName);
    }

    public void doExitGame() {
      Application.Quit();
    }

    void Start()
    {
        posArrivo = GameObject.Find("arrivo");
        posUscita = GameObject.Find("uscita");
        player = GameObject.Find("player");

        //in base al mondo in cui ti trovi cambia le istruzioni per arrivo e uscita
        switch(SceneManager.GetActiveScene().name)
            {
                case "World_auro":
                uscita = "World Gaia";
                break;
                case "World Gaia":
                arrivo = "World_auro";
                uscita = "Prison";
                break;
                case "Prison":
                arrivo = "World Gaia";
                uscita = "boss_battle";
                break;
                /*case "boss_battle":
                uscita = "Conclusione";
                break;*/
            default: break;
            }
    }
    //appena muore il boss si va alla scena conclusione
    void Update() {
      if(SceneManager.GetActiveScene().name == "boss_battle") {
        if(GameObject.Find("enemy_life").GetComponent<SpriteRenderer>().size.x <= 0f) {
          SceneManager.LoadScene("Conclusione");
        }
      }
    }
    //appena si tocca il collider di arrivo/uscita in base al mondo
    void OnTriggerEnter2D(Collider2D player)
    {
        //print(this.transform.name);
        if(this.transform.name == "arrivo")
        {
            SceneManager.LoadScene(arrivo);
        }
        else
        {
            SceneManager.LoadScene(uscita);
        }

    }
}
