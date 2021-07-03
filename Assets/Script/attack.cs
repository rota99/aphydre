using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
  public Vector3 attackSpeed;
  public GameObject explosion_prefab;

    // Start is called before the first frame update
    void Start()
    {

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

        Destroy(this.gameObject);
      }
    }
}
