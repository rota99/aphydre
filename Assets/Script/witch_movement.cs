using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class witch_movement : MonoBehaviour
{

  //variabili pubbliche
  public float speed;                       //velocità
  public Animator animator;

  //variabili locali
  float attackTime;

  // Start is called before the first frame update
  void Start()
  {

  }

  void stopAttack() {
    animator.SetBool("Attack", true);
    Thread.Sleep(48);
    animator.SetBool("Attack", false);
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
      attackTime += Time.deltaTime;

      animator.SetBool("Attack", true);

      if(attackTime > 0.5f) {
        animator.SetTrigger("Idle");
        attackTime = 0;
      }
    }

    //se l'utente vuole andare a destra e il personaggio è rivolto verso sinistra,
    //oppure se l'utente vuole andare a sinistra e il personaggio è rivolto a destra,
    //allora lo giro nella direzione corretta
    if(((Input.GetKey("right") || Input.GetKey("d")) && animator.transform.localScale.x < 0) || ((Input.GetKey("left") || Input.GetKey("a")) && animator.transform.localScale.x > 0))
      animator.transform.localScale = new Vector3(animator.transform.localScale.x*(-1), animator.transform.localScale.y, animator.transform.localScale.z);

    //animator.transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
    transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
  }
}
