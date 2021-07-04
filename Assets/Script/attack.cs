using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
  public Vector3 attackSpeed;
  public GameObject explosion_prefab;

  Animator anim;
  int i = 0;


  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    this.transform.position -= attackSpeed*Time.deltaTime;
  }

  void OnTriggerEnter2D(Collider2D witch) {
    if(witch.transform.name.Contains("witch")) {
      i++;

      if(witch.transform.name.Contains("B_")) {
        anim = GameObject.Find("playerBWR").transform.Find("B_witch_idle_0").GetComponent<Animator>();

        GameObject explosion = Instantiate(explosion_prefab);
        explosion.transform.position = this.transform.position;

        anim.SetTrigger("TakeDamage");

        GameObject.Find("blue_life").GetComponent<SpriteRenderer>().size -= new Vector2(0f, 1.5f);
        GameObject.Find("blue_life").transform.position += new Vector3(-1.5f * i, 0f, 0f);

        if(GameObject.Find("blue_life").GetComponent<SpriteRenderer>().size.y <= 0f) {
          Destroy(GameObject.Find("blue_life"));
          GameObject.Find("B_witch_idle_0").GetComponent<Collider2D>().enabled = false;
          GameObject.Find("W_witch_idle_0").GetComponent<Collider2D>().enabled = true;
          anim.ResetTrigger("TakeDamage");
          anim.SetTrigger("Death");
          i = 0;
        }
      }
      else if(witch.transform.name.Contains("W_")) {
        anim = GameObject.Find("playerBWR").transform.Find("W_witch_idle_0").GetComponent<Animator>();

        GameObject explosion = Instantiate(explosion_prefab);
        explosion.transform.position = this.transform.position;

        anim.SetTrigger("TakeDamageW");

        GameObject.Find("white_life").GetComponent<SpriteRenderer>().size -= new Vector2(0f, 1.5f);
        GameObject.Find("white_life").transform.position += new Vector3(-1.5f * i, 0f, 0f);

        if(GameObject.Find("white_life").GetComponent<SpriteRenderer>().size.y <= 0f) {
          Destroy(GameObject.Find("white_life"));
          GameObject.Find("W_witch_idle_0").GetComponent<Collider2D>().enabled = false;
          GameObject.Find("R_witch_idle_0").GetComponent<Collider2D>().enabled = true;
          anim.ResetTrigger("TakeDamage");
          anim.SetTrigger("Death");
          i = 0;
        }
      }
      else {
        anim = GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").GetComponent<Animator>();

        GameObject explosion = Instantiate(explosion_prefab);
        explosion.transform.position = this.transform.position;

        anim.SetTrigger("TakeDamage");

        //player_status.transform.Find("b_life")

        GameObject.Find("red_life").GetComponent<SpriteRenderer>().size -= new Vector2(0f, 1.5f);
        GameObject.Find("red_life").transform.position += new Vector3(-1.5f * i, 0f, 0f);

        if(GameObject.Find("red_life").GetComponent<SpriteRenderer>().size.y <= 0f) {
          Destroy(GameObject.Find("red_life"));
          GameObject.Find("R_witch_idle_0").GetComponent<Collider2D>().enabled = false;
          anim.ResetTrigger("TakeDamage");
          anim.SetTrigger("Death");
          i = 0;
        }
      }

      Destroy(this.gameObject);
    }
  }
}
