using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour {
  private void Start() {
    Debug.Log("Title UI");
  }

  public void StartMain() {
    SceneManager.LoadScene(1);
  }
}