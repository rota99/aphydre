using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_movement : MonoBehaviour
{
  //variabili pubbliche
  public float speed;                       //velocità

  // Update is called once per frame
  void Update()
  {
    float modificatore;

    if(Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0) {
      //se sia l'asse orizzontale che verticale sono diversi da 0, i due assi premuti sono diversi
      modificatore = Mathf.Sqrt(2);
    }
    else {
      modificatore = 1;
    }

    if(Input.GetKeyDown("right") || Input.GetKeyDown("left") || Input.GetKeyDown("d") || Input.GetKeyDown("a") || Input.GetKeyDown("down") || Input.GetKeyDown("s")) {
      GetComponent<Animation>().Play("blue-running");
    }
    else{
      GetComponent<Animation>().Stop("blue-running");
    }

    //se l'utente vuole andare a destra e il personaggio è rivolto verso sinistra,
    //oppure se l'utente vuole andare a sinistra e il personaggio è rivolto a destra,
    //allora lo giro nella direzione corretta
    if(((Input.GetKey("right") || Input.GetKey("d")) && transform.localScale.x < 0) || ((Input.GetKey("left") || Input.GetKey("a")) && transform.localScale.x > 0))
      transform.localScale = new Vector3(transform.localScale.x*(-1), transform.localScale.y, transform.localScale.z);

    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
  }
}
