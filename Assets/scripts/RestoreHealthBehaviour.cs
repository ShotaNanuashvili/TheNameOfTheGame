using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class RestoreHealthBehaviour : MonoBehaviour
{
  public int Strength;
  
  void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Player"))
    {
      HealthBehaviour health = collision.gameObject.GetComponent<HealthBehaviour>();
      if(health != null)
        health.ApplyHealing(Strength);
    }
  }
}