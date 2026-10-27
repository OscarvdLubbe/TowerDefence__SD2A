using System;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    //path 1 is the long path and path 2 is the long path
    private Transform[][] Paths;
    
    public static event Action Enemy_1_Dead;
    [SerializeField] private Transform[] path1;
    [SerializeField] private Transform[] path2;
    [SerializeField] private Transform[] path3;
    [SerializeField] private Transform[] path4;
    [SerializeField] private Transform[] path5;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float health = 10f;
    private int currentTarget = 0;

    public void Init(Transform[] Point)
        {
            Paths = new Transform[][]
            {
                path1,
                path2,
                path3,
                path4,
                path5  
            };
            path1 = Point;
            path2 = Point;
            path3 = Point;
            path4 = Point;
            path5 = Point;
        }



    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, path1[currentTarget].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, path1[currentTarget].position) < 0.1f)
        {
            currentTarget++;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Enemy_1_Dead?.Invoke();
            //mss explosie ofzos
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("-HP block"))
        {
            Destroy(gameObject);
            
            //je kriigt coins als je hem verslaat en er gaat HP van je base af als hij aan het einden komt.
        }
        if (collision.CompareTag("Bullet"))
        {
            health--;
        }
    }
}
