using System.Collections.Generic;
using UnityEngine;

public class TowerDirectionToEnmey : MonoBehaviour
{
    public List<GameObject> enemys = new List<GameObject>();
    [SerializeField] private GameObject enemy_1;
    [SerializeField] private GameObject enemy_2;
    private Vector2 direction;
    //public Collider2D C2D;
    public float speed = 100000000f;
    private int i;

    void Start()
    {

    }
    void Update()
    {
        // if (enemys == null || enemys.Count <= 0)
        // {
        //     transform.Rotate(0f, 0f, 50f * Time.deltaTime);
        // }
        // else
        // {
            // Vector3 direction = enemys[0].transform.position - transform.position;
            // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            // Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90f));
            // transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed * Time.deltaTime);
        //}
    }
}
