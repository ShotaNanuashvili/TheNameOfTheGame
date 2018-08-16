using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class EnemyDeathBehaviour : MonoBehaviour
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
    Destroy(gameObject);
  }
}