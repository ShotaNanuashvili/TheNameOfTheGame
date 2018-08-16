using UnityEngine;
using System.Collections;

public class BulletEngine : MonoBehaviour
{
    public float maxSpeed = 40f;
    GameObject characterEngine;
    Vector3 pos;
    Vector3 velocity;

    //---------------------------------------------------------------------------------------------------
    void Awake()
    {
        characterEngine = GameObject.FindGameObjectWithTag("Player");
        velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);
        pos = transform.position;
    }

    //---------------------------------------------------------------------------------------------------

    void Start()
    {
        if (!characterEngine.GetComponent<PlayerMove>().facingRight)
        {
            velocity = new Vector3(maxSpeed * 1 * Time.deltaTime, 0, 0);
        }

        else
        {
            velocity = new Vector3(maxSpeed * -1 * Time.deltaTime, 0, 0);
        }
    }

    //---------------------------------------------------------------------------------------------------
    void Update()
    {
        pos += velocity;
        transform.position = pos;
    }
}