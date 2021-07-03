using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_interaction1 : MonoBehaviour
{
    public string[] frasi_suore = new string[4];
    public string[] frasi_plebei = new string[7];
    public string[] frase_soldato = new string[1];
    public GameObject npc_message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D npc)
    {
        if (npc.transform.name.Contains("suora"))
        {
            if (Input.GetKeyDown("x"))
            {
                //genero un numero casuale compreso tra 0 e 3
                int i = Random.Range(0, frasi_suore.Length);

                npc_message.SetActive(true);

                npc_message.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = frasi_suore[i].ToString();
            }
        }

        if (npc.transform.name.Contains("plebeo"))
        {
            if (Input.GetKeyDown("x"))
            {
                //genero un numero casuale compreso tra 0 e 3
                int i = Random.Range(0, frasi_plebei.Length);

                npc_message.SetActive(true);

                npc_message.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = frasi_plebei[i].ToString();
            }
        }

        if (npc.transform.name.Contains("soldato"))
        {
            if (Input.GetKeyDown("x"))
            {
                //genero un numero casuale compreso tra 0 e 3
                int i = Random.Range(0, frase_soldato.Length);

                npc_message.SetActive(true);

                npc_message.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = frase_soldato[i].ToString();
            }
        }
    }

    void OnTriggerExit2D(Collider2D npc)
    {
        npc_message.SetActive(false);
    }
}
