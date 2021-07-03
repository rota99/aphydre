using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_interaction : MonoBehaviour
{
  public GameObject open_sound;
  public GameObject close_sound;
  public GameObject potion_found_message;
  public GameObject hp_parent;
  public GameObject hp_prefab;

  string[] chests = new string[8] {"","","","","","","",""};

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D chest) {
    if (chest.transform.name.Contains("chest") && Array.IndexOf(chests, chest.transform.name) < 0) {
      if (Input.GetKey("x")) {
        chests[Array.IndexOf(chests, "")] = chest.transform.name;

        chest.GetComponent<Animator>().SetBool("chest_opened", true);
        chest.transform.Find("chest_open_sound").GetComponent<AudioSource>().Play();
        potion_found_message.SetActive(true);

        //GameObject hp = Instantiate(hp_prefab) as GameObject;
        //hp.transform.parent = hp_parent.transform;

        GameObject hp = Instantiate(hp_prefab);
        float posx = -37 - (-2 * (hp_parent.transform.childCount - 1));

        hp.transform.position = new Vector2((float)posx, 19.55f);

        hp.transform.SetParent(hp_parent.transform, false);
      }
    }
  }

  void OnTriggerExit2D(Collider2D chest) {
    if (chest.transform.name.Contains("chest")) {
      if (chest.GetComponent<Animator>().GetBool("chest_opened")) {
        chest.GetComponent<Animator>().SetBool("chest_opened", false);
        chest.transform.Find("chest_close_sound").GetComponent<AudioSource>().Play();
        potion_found_message.SetActive(false);
      }
    }
  }
}
