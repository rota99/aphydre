using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text_manager_intro : MonoBehaviour
{
  public string[] texts = new string[5];
  public GameObject textArea;

  int i = 0;

  // Start is called before the first frame update
  void Start()
  {
    textArea.GetComponent<UnityEngine.UI.Text>().text = texts[0].ToString();
    i++;
    //print("start ", i);
  }

  public void nextText() {
    //print("next prima ", i);
    textArea.GetComponent<UnityEngine.UI.Text>().text = texts[i].ToString();
    i++;
    //print("next dopo ", i);
  }

  public void prevText() {
    //print("prev prima ", i);
    textArea.GetComponent<UnityEngine.UI.Text>().text = texts[i].ToString();
    i--;
    //print("prev dopo ", i);
  }
}
