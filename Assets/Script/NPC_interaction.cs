using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_interaction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D npc)
    {
        print("trovato npc");
        if (npc.transform.name.Contains("suora"))
        {
            print("ecco una suora");
            //if (Input.GetKey("x"))
           //{
                //chest.GetComponent<Animator>().SetBool("chest_opened", true);
                //chest.transform.Find("chest_open_sound").GetComponent<AudioSource>().Play();
                //potion_found_message.rectTransform.localScale = new Vector3(0.05f, 0.09f, 0.0f);
                //potion_found_message.SetActive(true);
            //}
        }
    }

    void OnTriggerExit2D(Collider2D npc)
    {
        if (npc.transform.name.Contains("suora"))
        {
            //if (chest.GetComponent<Animator>().GetBool("chest_opened"))
            //{
                //chest.GetComponent<Animator>().SetBool("chest_opened", false);
                //chest.transform.Find("chest_close_sound").GetComponent<AudioSource>().Play();
                //potion_found_message.rectTransform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
                //potion_found_message.SetActive(false);
            //}
        }
    }
}
