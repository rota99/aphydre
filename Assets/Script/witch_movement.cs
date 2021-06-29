using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class witch_movement : MonoBehaviour
{

  //variabili pubbliche
  public float speed;                       //velocità
  public Animator animator;

  // Start is called before the first frame update
  void Start()
  {

  }

  public void stopAttack() {
    animator.SetBool("Attack", false);
    print("passato tempo");
  }

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

    if(Input.GetKey("left") || Input.GetKey("right") || Input.GetKey("down") || Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("s")) {
      animator.SetFloat("Speed", 1);
    }
    else {
      animator.SetFloat("Speed", 0);
    }

    if(Input.GetKey("z")) {
      animator.SetBool("Attack", true);
      Thread.Sleep(48);
      animator.SetBool("Attack", false);
    }

    //se l'utente vuole andare a destra e il personaggio è rivolto verso sinistra,
    //oppure se l'utente vuole andare a sinistra e il personaggio è rivolto a destra,
    //allora lo giro nella direzione corretta
    if(((Input.GetKey("right") || Input.GetKey("d")) && transform.localScale.x < 0) || ((Input.GetKey("left") || Input.GetKey("a")) && transform.localScale.x > 0))
      transform.localScale = new Vector3(transform.localScale.x*(-1), transform.localScale.y, transform.localScale.z);

    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
  }
}
