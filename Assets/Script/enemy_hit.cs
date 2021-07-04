using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hit : MonoBehaviour
{
  float waterTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      waterTime += Time.deltaTime;
      
      if(this.gameObject.transform.name.Contains("water") && waterTime > 1.5f) {
        Destroy(this.gameObject);
      }
    }

    void OnTriggerEnter2D(Collider2D enemy) {
      if(!this.gameObject.transform.name.Contains("water"))
        Destroy(this.gameObject);
    }
}
