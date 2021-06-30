using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_interaction : MonoBehaviour
{
  public AudioSource chestOpen;
  public AudioSource chestClose;

  // Start is called before the first frame update
  void Start()
  {
    chestOpen = gameObject.AddComponent<AudioSource>();
    chestClose = gameObject.AddComponent<AudioSource>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter2D(Collider2D chest) {
    if(Input.GetKey("x") && chest.transform.name.Contains("chest")) {
      chest.GetComponent<Animator>().SetBool("chest_opened", true);
    }
    else {
      chest.GetComponent<Animator>().SetBool("chest_opened", false);
    }
  }
}
