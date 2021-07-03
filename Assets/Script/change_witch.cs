using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_witch : MonoBehaviour
{
  public GameObject[] witchArray = new GameObject[3];
  public GameObject b_witch_img;
  public GameObject w_witch_img;
  public GameObject r_witch_img;

  float[] positionNegArray = new float[3] {0f, -200f, -400f};
  float[] positionPosArray = new float[3] {0f, 200f, 400f};


  // Update is called once per frame
  void Update()
  {
    //premi spazio per cambiare strega
    if(Input.GetKeyDown("space")) {
      GameObject t = witchArray[witchArray.Length - 1];
      for(int i = witchArray.Length - 1; i > 0; i--)
        witchArray[i] = witchArray[i - 1];
      witchArray[0] = t;

      if(witchArray[0].transform.name.Contains("B_")) {
        b_witch_img.SetActive(true);
        w_witch_img.SetActive(false);
        r_witch_img.SetActive(false);
      }
      else if(witchArray[0].transform.name.Contains("W_")) {
        b_witch_img.SetActive(false);
        w_witch_img.SetActive(true);
        r_witch_img.SetActive(false);
      }
      else if(witchArray[0].transform.name.Contains("R_")) {
        b_witch_img.SetActive(false);
        w_witch_img.SetActive(false);
        r_witch_img.SetActive(true);
      }

      witchArray[0].GetComponent<Collider2D>().enabled = true;
      witchArray[1].GetComponent<Collider2D>().enabled = false;

      if(witchArray.Length == 3)
        witchArray[2].GetComponent<Collider2D>().enabled = false;

      for(int i = 0; i <= witchArray.Length - 1; i++) {
        witchArray[i].transform.localPosition = new Vector2(positionNegArray[i], witchArray[i].transform.localPosition.y);
      }
    }
  }
}
