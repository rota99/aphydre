using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hit : MonoBehaviour
{
  public Vector3 attackSpeed;
  public GameObject attackEnd_prefab;

  float waterTime;
  GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
      enemy = GameObject.Find("enemy");
    }

    // Update is called once per frame
    void Update()
    {
      waterTime += Time.deltaTime;

      if(this.gameObject.transform.name.Contains("water") && waterTime > 1.5f) {
        Destroy(this.gameObject);
        enemy.GetComponent<Animator>().ResetTrigger("TakeDamage");
      }
      else {
        this.transform.position += attackSpeed*Time.deltaTime;
      }
    }

    void OnTriggerEnter2D(Collider2D enemy) {
      enemy.GetComponent<Animator>().SetTrigger("TakeDamage");

      if(!this.gameObject.transform.name.Contains("water") && enemy.transform.name.Contains("enemy")) {
        GameObject attackEnd = Instantiate(attackEnd_prefab);
        attackEnd.transform.position = this.transform.position;
        Destroy(this.gameObject);
      }
    }
}
