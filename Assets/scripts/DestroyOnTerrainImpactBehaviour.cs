using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class DestroyOnTerrainImpactBehaviour : MonoBehaviour
{
  void OnCollisionEnter2D(Collision2D collision)
  {
    if(collision.gameObject.CompareTag("Ground"))
    {
            Destroy(gameObject);
    }
  }
}