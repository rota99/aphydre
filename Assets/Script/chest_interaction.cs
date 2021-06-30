using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_interaction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D chest) {
      chest.SetBool("chest_opened", true);
    }
}
