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
        //prima di arrivare alla cella della strega rossa si vedono solo le due streghe B e W
        //mentre quella R nel playerBWR è disattivata
        redWitch = GameObject.Find("R_witch_idle_0 (1)");
        player1 = GameObject.Find("playerBWR").transform.Find("R_witch_idle_0").gameObject;

    }

        //quando entra in contatto con il Box Collider2D 
        void OnTriggerEnter2D(Collider2D player)
    {
        //la porta scompare e viene riprodotto il suono della porta
        this.GetComponent<SpriteRenderer>().size = new Vector2(0f, 0f);
        this.GetComponent<AudioSource>().Play(0);

        //scompare la strega nella stanza e viene attivata nel playerBWR
        redWitch.SetActive(false);
        player1.SetActive(true);
    }
}
