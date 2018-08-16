using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class WinOnPlayerImpactBehaviour : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Player"))
    {
      Debug.Log("We won the Game!");
    }
  }
}