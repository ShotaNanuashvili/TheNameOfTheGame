using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
  public string SceneName;

  void Update()
  {
    if (Input.GetKeyDown("r"))
      SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
  }
}