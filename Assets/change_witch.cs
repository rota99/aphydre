using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_witch : MonoBehaviour
{
  public GameObject[] witchArray = new GameObject[3];

  int[] positionNegArray = new int[3] {0, -200, -400};
  int[] positionPosArray = new int[3] {0, 200, 400};

  GameObject[] witchArray2 = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
      if(witchArray[2] == null) {
        witchArray2[0] = witchArray[0];
        witchArray2[1] = witchArray[1];
      }
    }

    // Update is called once per frame
    void Update()
    {
      //premi spazio per cambiare strega
      if(Input.GetKey("space")) {
        if(witchArray2 == null || witchArray2.Length == 0) {
          GameObject t = witchArray[witchArray.Length - 1];
          for(int i = witchArray.Length - 1; i > 0; i--)
            witchArray[i] = witchArray[i - 1];
          witchArray[0] = t;

          for(int i = 0; i < witchArray.Length - 1; i++) {
            if(transform.localScale.x < 0) {
              witchArray[i].transform.position = new Vector3(positionNegArray[i], witchArray[i].transform.position.y, witchArray[i].transform.position.z);
            }
            else {
              witchArray[i].transform.position = new Vector3(positionPosArray[i], witchArray[i].transform.position.y, witchArray[i].transform.position.z);
            }
          }
        }
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
        }
      }
    }
}
