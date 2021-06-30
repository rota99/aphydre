using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_changer : MonoBehaviour
{
  //funzione che viene chiamata quando viene fatto il click sul pulsante "start"
  //passo come parametro il nome della scena verso cui voglio andare e poi
  //eseguo la funzione SceneManager.LoadScene() dove specifico il nome della scena da caricare
  public void changeMenuScene(string sceneName) {
    SceneManager.LoadScene(sceneName);
  }
}
