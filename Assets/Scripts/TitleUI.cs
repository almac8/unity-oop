using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUI : MonoBehaviour {
  public void StartMain() {
    SceneManager.LoadScene(1);
  }
}