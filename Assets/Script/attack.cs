using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
  public Vector3 attackSpeed;
  public GameObject explosion_prefab;

  Animator anim;

    // Start is called before the first frame update
    void Start()
    {
      anim = GameObject.Find("player").transform.GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      this.transform.position -= attackSpeed*Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D witch) {
      if(witch.transform.name.Contains("witch")) {
        GameObject explosion = Instantiate(explosion_prefab);
        explosion.transform.position = this.transform.position;

        anim.SetTrigger("TakeDamage");

        //player_status.transform.Find("b_life")

        GameObject.Find("blue_life").GetComponent<SpriteRenderer>().size -= new Vector2(0f, 1.5f);
        GameObject.Find("blue_life").transform.position += new Vector3(-1.5f, 0f, 0f);

        if(GameObject.Find("blue_life").GetComponent<SpriteRenderer>().size.y <= 0f) {
          print("qui");
          Destroy(GameObject.Find("blue_life"));
          anim.ResetTrigger("TakeDamage");
          anim.SetTrigger("Death");
        }

        Destroy(this.gameObject);
      }
    }
}
