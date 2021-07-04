using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_time : MonoBehaviour
{
  float explosionTime;
  Animator anim;

  void Start() {
    if(GameObject.Find("playerBWR").transform.Find("B_witch_idle_0").GetComponent<Collider2D>().enabled) {
      anim = GameObject.Find("playerBWR").transform.Find("B_witch_idle_0").GetComponent<Animator>();
    }
    else if(GameObject.Find("playerBWR").transform.Find("W_witch_idle_0").GetComponent<Collider2D>().enabled) {
      anim = GameObject.Find("playerBWR").transform.Find("W_witch_idle_0").GetComponent<Animator>();
    }
    else if(GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").GetComponent<Collider2D>().enabled) {
      anim = GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").GetComponent<Animator>();
    }
  }

  // Update is called once per frame
  void Update()
  {
    explosionTime += Time.deltaTime;

    if(explosionTime > 0.5f) {
      Destroy(this.gameObject);
      anim.ResetTrigger("TakeDamage");
    }
  }
}
