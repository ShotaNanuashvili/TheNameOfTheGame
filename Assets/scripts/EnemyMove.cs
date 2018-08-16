using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour {
    public int enemySpeed;
    public int xMoveDirection;
    public Transform target;
    const float MINDIST = 1.2f;
	
	// Update is called once per frame
    void Start()
    {
        MyStart();
    }

    // Update is called once per frame
    void Update()
    {
        MyUpdate();
    }
            

    // Set the target of the chaser
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }

    public virtual void Move()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * enemySpeed;
    }

    public void MyStart()
    {
        // if no target specified, assume the player
        if (target == null)
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    public void MyUpdate()
    {
        Move();
        if (target == null)
            return;

        //get the distance between the chaser and the target
        float distance = Vector2.Distance(transform.position, target.position);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if (distance < MINDIST)
        {
            HealthBehaviour health = target.GetComponent(typeof(HealthBehaviour)) as HealthBehaviour;
            DamageBehaviour damage = gameObject.GetComponent(typeof(DamageBehaviour)) as DamageBehaviour;
            if (health != null && damage != null)
                health.ApplyDamage(damage.DamageAmount);
        }

        if (target.position.x > transform.position.x && xMoveDirection < 0
            || target.position.x < transform.position.x && xMoveDirection > 0)
        {
            xMoveDirection *= -1;
        }
    }
}
