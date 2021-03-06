using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_interaction : MonoBehaviour
{
  public GameObject open_sound;
  public GameObject close_sound;
  public GameObject potion_found_message;

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerStay2D(Collider2D chest) {
    if (chest.transform.name.Contains("chest")) {
      if (Input.GetKey("x")) {

        chest.GetComponent<Animator>().SetBool("chest_opened", true);
        chest.transform.Find("chest_open_sound").GetComponent<AudioSource>().Play();
        potion_found_message.SetActive(true);
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
