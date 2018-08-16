using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class BlinkSpriteBehaviour : MonoBehaviour
{
    public bool IsBlinking = false;
    public float BlinkDurationInSeconds = 2;
    public float BlinkIntervalInSeconds = 0.5f;

    private float _blinkTimer;
    private int _blinkCounter;

    void Update()
    {
        if (IsBlinking)
        {
            _blinkTimer += Time.deltaTime;
            if (_blinkTimer >= BlinkIntervalInSeconds)
            {
                // Toggle the visibility.
                SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
                renderer.enabled = !renderer.enabled;
                // Toggle the interval;

                _blinkTimer -= BlinkIntervalInSeconds;
                _blinkCounter--;
                if (_blinkCounter <= 0)
                {
                    IsBlinking = false;
                    renderer.enabled = true;
                }
            }
        }
    }

    public void StartBlinking()
    {
        _blinkTimer = 0;
        _blinkCounter = (int)(BlinkDurationInSeconds / BlinkIntervalInSeconds);
        IsBlinking = true;
    }
}