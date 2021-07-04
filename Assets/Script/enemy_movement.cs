using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
  public int chances;
  public GameObject fire_prefab;
  public GameObject panel;

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
      //gameObject.GetComponent<Animator>().SetBool("Attack", true);

      GameObject fire = Instantiate(fire_prefab);
      fire.transform.SetParent(panel.transform, false);

      /*while(attackTime < 1.33f) {
        attackTime += Time.deltaTime;
      }*/

      //GetComponent<Animator>().SetBool("Attack", false);
    }
  }
}
