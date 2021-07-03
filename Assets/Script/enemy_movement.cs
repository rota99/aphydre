using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
  public Vector2 position1;
  public Vector2 position2;
  public float enemy_speed;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float step = enemy_speed * Time.deltaTime;

    // move sprite towards the target location
    transform.position = Vector2.MoveTowards(transform.position, position1, step);
  }
}
