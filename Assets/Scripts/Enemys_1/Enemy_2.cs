using System;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    public static event Action Enemy_2_Dead;
    [SerializeField] private Transform[] path;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float health = 5f;
    private int currentTarget = 0;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, path[currentTarget].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, path[currentTarget].position) < 0.1f)
        {
            currentTarget++;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Enemy_2_Dead?.Invoke();
            //death effect
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("-HP block"))
        {
            Destroy(gameObject);
            //je kriigt coins als je hem verslaat en er gaat HP van je base af als hij aan het einden komt.
        }
    }
}
