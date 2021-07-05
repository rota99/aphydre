using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch_attack : MonoBehaviour
{
  public GameObject water_prefab;
  public GameObject spell_prefab;
  public GameObject fire_prefab;
  public GameObject panel;

  Vector3 enemy_pos;

    // Start is called before the first frame update
    void Start()
    {
      enemy_pos = GameObject.Find("enemy").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("z")) {
        if(GameObject.Find("playerBWR").transform.Find("B_witch_idle_0").GetComponent<Collider2D>().enabled) {
          GameObject water = Instantiate(water_prefab);
          water.transform.SetParent(panel.transform, false);
          water.transform.position = new Vector3(enemy_pos.x, enemy_pos.y - 20f, -1f);
        }
        else if(GameObject.Find("playerBWR").transform.Find("W_witch_idle_0").GetComponent<Collider2D>().enabled) {
          GameObject spell = Instantiate(spell_prefab);
          spell.transform.SetParent(panel.transform, false);
        }
        else if(GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").GetComponent<Collider2D>().enabled) {
          GameObject fire = Instantiate(fire_prefab);
          fire.transform.SetParent(panel.transform, false);
        }
      }
    }
}
