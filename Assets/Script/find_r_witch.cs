using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class find_r_witch : MonoBehaviour
{
    private GameObject player1;
    private GameObject redWitch;
    //private GameObject player2;

    void Start()
    {
        //player1 = GameObject.Find("playerBWR").transform.Find("R_witch_idle_0");
        redWitch = GameObject.Find("R_witch_idle_0 (1)");
        player1 = GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").gameObject;

    }

        void OnTriggerEnter2D(Collider2D player)
    {
        print("sale");
        this.GetComponent<SpriteRenderer>().size = new Vector2(0f, 0f);
        this.GetComponent<AudioSource>().Play(0);

        //player1.SetActive(false);
        redWitch.SetActive(false);
        player1.SetActive(true);
    }
}
