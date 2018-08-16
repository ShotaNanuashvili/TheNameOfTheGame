using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class RestoreAmmoBehaviour : MonoBehaviour
{
  public int Strength;
  
  void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Player"))
    {
      collision.gameObject.GetComponent<BulletSpawner>().ammoCount += Strength;
    }
  }
}