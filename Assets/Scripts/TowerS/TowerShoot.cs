using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public List<GameObject> enemys = new List<GameObject>();
    public GameObject FishBullet_1;
    public float speed = 16f;
    private float attackTimer = 0f;
    void Update()
    { 
        attackTimer += Time.deltaTime;
        if (enemys == null || enemys.Count <= 0)
        {
            //idle animtation
            return;
        }
        //stage 1
        if (gameObject.tag == "BaseTower_1")
        {
            //switch statment

            if (attackTimer >= 0.8f)
            {
                attackTimer = 0f;
                GameObject spawnFishAttack = Instantiate(FishBullet_1, transform.position, Quaternion.identity);
                spawnFishAttack.GetComponent<FishAttack_1>().Initialize(enemys[0].transform);
            }
        }
        if (gameObject.tag == "BaseTower_2")
        {
            //switch statment

            if (attackTimer >= 0.4f)
            {
                attackTimer = 0f;
                GameObject spawnFishAttack = Instantiate(FishBullet_1, transform.position, Quaternion.identity);
                spawnFishAttack.GetComponent<FishAttack_1>().Initialize(enemys[0].transform);
            }
        }

        Vector3 direction = enemys[0].transform.position - transform.position;
        transform.right = -direction.normalized;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemys.Add(collision.gameObject);
            //een for loop gebruiken.
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemys.Remove(collision.gameObject);
        }
    }
}
