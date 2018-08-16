using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDeathBehaviour : MonoBehaviour
{
  void Update()
  {
    HealthBehaviour health = gameObject.GetComponent(typeof(HealthBehaviour)) as HealthBehaviour;
    if( health != null)
      if (health.IsDead())
        ProcessDeath();
  }
  
  private void ProcessDeath()
  {
        // DO SOMETHING HERE!!!!!!
        SceneManager.LoadScene("Scene1");
  }
}