using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_time : MonoBehaviour
{
  float explosionTime;

  // Update is called once per frame
  void Update()
  {
    explosionTime += Time.deltaTime;

    if(explosionTime > 0.5f)
      Destroy(this.gameObject);
  }
}
