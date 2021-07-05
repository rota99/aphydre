using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_attack_time : MonoBehaviour
{
  float attackTime;
  GameObject enemy;

  // Start is called before the first frame update
  void Start()
  {
    enemy = GameObject.Find("enemy");
  }

  // Update is called once per frame
  void Update()
  {
    attackTime += Time.deltaTime;

    if(attackTime > 0.5f) {
      Destroy(this.gameObject);
      enemy.GetComponent<Animator>().ResetTrigger("TakeDamage");
    }
  }
}
