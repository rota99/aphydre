using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
  public int chances;
  public GameObject fire_prefab;
  public GameObject panel;

    float attackTime;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    int n = Random.Range(0, chances);
    int m = Random.Range(0, chances);

    if(n == m) {
      GetComponent<Animator>().SetBool("attack", true);
      
      attackTime += Time.deltaTime;

      GameObject fire = Instantiate(fire_prefab);
      fire.transform.SetParent(panel.transform, false);

      if(attackTime > 1.33f) {
        GetComponent<Animator>().SetBool("attack", false);
      }
    }
  }
}
