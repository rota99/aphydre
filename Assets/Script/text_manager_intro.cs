using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_manager_intro : MonoBehaviour
{
  public string[] texts = new string[4];
  public GameObject textArea;
  public GameObject prevButton;
  public GameObject nextButton;

  int i = 0;

  // Start is called before the first frame update
  void Start()
  {
    prevButton.GetComponent<Button>().interactable = false;
    textArea.GetComponent<UnityEngine.UI.Text>().text = texts[0].ToString();
  }

  void Update() {
    if(i <= 0) {
      prevButton.GetComponent<Button>().interactable = false;
    }
    else {
      prevButton.GetComponent<Button>().interactable = true;
    }
  }

  public void nextText() {
    i++;
    textArea.GetComponent<UnityEngine.UI.Text>().text = texts[i].ToString();
  }

  public void prevText() {
    if(i > 0) {
      i--;
      textArea.GetComponent<UnityEngine.UI.Text>().text = texts[i].ToString();
    }
  }
}
