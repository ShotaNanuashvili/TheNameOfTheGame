using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System;

public class HealthBehaviour : MonoBehaviour
{
    public int MaxHealth;
    public int MinHealth;
    public bool IsImmune;
    public float ImmunityDurationInSeconds;

    private TimeSpan ImmuneDuration;

    private int _currentHealth;
    private TimeSpan _immuneTime;

    public bool IsAlive()
    {
        return _currentHealth > MinHealth;
    }

    public bool IsDead()
    {
        return _currentHealth <= MinHealth;
    }

    void Start()
    {

        _currentHealth = MaxHealth;
        _immuneTime = TimeSpan.FromSeconds(0);
    }

    void Update()
    {
        if (IsImmune)
        {
            _immuneTime -= TimeSpan.FromSeconds(Time.deltaTime);
            if (_immuneTime <= TimeSpan.FromSeconds(0))
            {
                IsImmune = false;
                gameObject.layer = 10;
                Debug.Log("Immunity Lost!");
            }
        }
    }

    public void ApplyDamage(int damageAmount)
    {
        if (!IsImmune)
        {
            _currentHealth -= damageAmount;
            _currentHealth = Mathf.Clamp(_currentHealth, MinHealth, MaxHealth);
            if (gameObject.CompareTag("Player"))
                ApplyImmunity();
            Debug.Log("Damage Taken! Amount: " + damageAmount.ToString());
        }

    }
    public void ApplyHealing(int healingAmount)
    {
        _currentHealth += healingAmount;
        _currentHealth = Mathf.Clamp(_currentHealth, MinHealth, MaxHealth);
        Debug.Log("Healing Taken! Amount: " + healingAmount.ToString());
    }

    public void ApplyImmunity()
    {
        IsImmune = true;
        _immuneTime = TimeSpan.FromSeconds(ImmunityDurationInSeconds);
        var blinking = gameObject.GetComponent<BlinkSpriteBehaviour>();
        if(blinking != null) blinking.StartBlinking();
    }
}
