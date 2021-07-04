using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class witch_movement : MonoBehaviour
{
  //variabili pubbliche
  public float speed;                       //velocità
  public Animator animatorBlue;
  public Animator animatorWhite;
  public float[] coordinate = new float[4];

  // Start is called before the first frame update
  void Start()
  {
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

    //se l'utente vuole andare a destra e il personaggio è rivolto verso sinistra,
    //oppure se l'utente vuole andare a sinistra e il personaggio è rivolto a destra,
    //allora lo giro nella direzione corretta
    if(((Input.GetKey("right") || Input.GetKey("d")) && transform.localScale.x < 0) || ((Input.GetKey("left") || Input.GetKey("a")) && transform.localScale.x > 0)) {
      transform.localScale = new Vector3(transform.localScale.x*(-1), transform.localScale.y, transform.localScale.z);
    }

    checkPosition(this.transform.localPosition, modificatore);
  }

  void checkPosition(Vector3 pos, float modificatore) {
    //top
    if((Input.GetKey("up") || Input.GetKey("w")) && pos.y < coordinate[0])
      transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
    //right
    else if((Input.GetKey("right") || Input.GetKey("d")) && pos.x < coordinate[1])
      transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
    //down
    else if((Input.GetKey("down") || Input.GetKey("s")) && pos.y > coordinate[2])
      transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
    //left
    else if((Input.GetKey("left") || Input.GetKey("a")) && pos.x > coordinate[3])
      transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*Time.deltaTime*speed/modificatore;
  }
}
