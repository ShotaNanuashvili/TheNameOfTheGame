using UnityEngine;
using UnityEngine.Events;
using System.Collections;

enum FriendType { Doctor, Nurse, Mother, Father, Friend }

public class ThrowPowerUpBehaviour : MonoBehaviour
{
  FriendType FriendType;

  void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Player"))
    {
      ThrowPowerUp();
    }
  }
  
  void ThrowPowerUp()
  {
    Debug.Log("NYI: Throw a Powerup!");
  }
}