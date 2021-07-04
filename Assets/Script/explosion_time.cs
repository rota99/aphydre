using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_time : MonoBehaviour
{
  float explosionTime;
  Animator anim;

  void Start() {
    anim = GameObject.Find("playerBWR").transform.GetChild(0).GetComponent<Animator>();
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
