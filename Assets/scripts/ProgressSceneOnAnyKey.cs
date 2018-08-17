using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ProgressSceneOnAnyKey : MonoBehaviour
{
  public string SceneName;

  void Update()
  {
    if (Input.anyKey)
      SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
  }
}