using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    [SerializeField] private Transform[] path1;
    [SerializeField] private Transform[] path2;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float health = 5f;
    private int currentTarget = 0;

    public void Init(Transform[] Point)
    {
        path1 = Point;
        path2 = Point;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, path1[currentTarget].position, speed * Time.deltaTime);
        if (path1 == null)
        {
            Destroy(gameObject);
        }
        if (Vector2.Distance(transform.position, path1[currentTarget].position) < 0.1f)
        {
            currentTarget++;
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
