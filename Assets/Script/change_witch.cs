using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_witch : MonoBehaviour
{
  public GameObject[] witchArray = new GameObject[3];

  float[] positionNegArray = new float[3] {0f, -200f, -400f};
  float[] positionPosArray = new float[3] {0f, 200f, 400f};

//  GameObject[] witchArray2 = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
    /*  if(witchArray[2] == null) {
        witchArray2[0] = witchArray[0];
        witchArray2[1] = witchArray[1];
      }*/
    }

    // Update is called once per frame
    void Update()
    {
      //premi spazio per cambiare strega
      if(Input.GetKeyDown("space")) {
        //if(witchArray2 == null || witchArray2.Length == 0) {
          GameObject t = witchArray[witchArray.Length - 1];
          for(int i = witchArray.Length - 1; i > 0; i--)
            witchArray[i] = witchArray[i - 1];
          witchArray[0] = t;

          for(int i = 0; i <= witchArray.Length - 1; i++) {
            witchArray[i].transform.localPosition = new Vector2(positionNegArray[i], witchArray[i].transform.localPosition.y);
          }
        /*}
        else{
          GameObject t = witchArray2[witchArray2.Length - 1];
          for(int i = witchArray2.Length - 1; i > 0; i--)
            witchArray2[i] = witchArray2[i - 1];
          witchArray2[0] = t;

          for(int i = 0; i < witchArray2.Length - 1; i++) {
            if(transform.localScale.x < 0) {
              witchArray2[i].transform.position = new Vector3(positionNegArray[i], witchArray2[i].transform.position.y, witchArray2[i].transform.position.z);
            }
            else {
              witchArray2[i].transform.position = new Vector3(positionPosArray[i], witchArray2[i].transform.position.y, witchArray2[i].transform.position.z);
            }
          }
        }*/
      }
    }
}
