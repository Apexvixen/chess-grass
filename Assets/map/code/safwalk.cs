using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class safwalk : MonoBehaviour
{
    [Header("its jojo's")]
    [SerializeField] private Rigidbody2D rb;

    [Header("speddyboy")]
    [SerializeField] private float moveSpeed = 4f;

    private Transform target;
    private int walkindex = 0;
    private void Start()
    {
        target = manager.main.walk[walkindex];
    }
    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            walkindex++;
           
            if (walkindex == manager.main.walk.Length)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                target = manager.main.walk[walkindex];
            }

        }
    }
    private void FixedUpdate()
    {
       Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }
}

