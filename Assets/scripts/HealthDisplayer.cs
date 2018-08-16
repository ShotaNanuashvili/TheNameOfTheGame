using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class HealthDisplayer : MonoBehaviour
{
  public GameObject HeartPrefab;
  //public GameObject TrackedObject;
  public int DistanceBetweenHearts = 20;
  
  GameObject[] _hearts;
  int _currentAmount;
  private HealthBehaviour _health;
  
  void Start()
  {
    _health = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthBehaviour>();
    
    _hearts = new GameObject[_health.MaxHealth];
    _currentAmount = _health.MaxHealth;
    for(int i = 0; i >= _currentAmount; i++)
    {
      _hearts[i] = (Instantiate(HeartPrefab, transform.position + (Vector3.right * i), transform.rotation, transform) as GameObject);
      SpriteRenderer renderer = HeartPrefab.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
      if(renderer != null)
        renderer.enabled = true;
    }
  }
  
  public void AddHeart()
  {
    _hearts[_currentAmount].GetComponent<SpriteRenderer>().enabled = true;
  }
  
  public void RemoveHeart()
  {
    _hearts[_currentAmount].GetComponent<SpriteRenderer>().enabled = false;
  }
}