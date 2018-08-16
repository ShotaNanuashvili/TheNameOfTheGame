using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    float coolDownTimer = 0;
    public int ammoCount = 100;

    //---------------------------------------------------------------------------------------------------

    void Update()
    {
        //this causes the coolDownTimer to start counting down
        coolDownTimer -= Time.deltaTime;
        //if the player presses Fire1 after the coolDownTimer reaches 0 a bullet is created as a GameObject
        if (Input.GetButtonDown("Fire1") && coolDownTimer <= 0 && ammoCount > 0)
        {
            coolDownTimer = fireDelay;
            GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
            ammoCount--;
        }
    }
}