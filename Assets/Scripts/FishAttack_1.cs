using UnityEngine;

public class FishAttack_1 : MonoBehaviour
{
    public float speed = 7f;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject,20f);
    }

    public void Initialize(Transform player)
    {
        direction = (player.position - transform.position).normalized;
    }

    void Update()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
        transform.up = -direction.normalized;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            //drop coins
        }
    }
}
