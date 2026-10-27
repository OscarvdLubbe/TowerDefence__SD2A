using System.Collections.Generic;
using UnityEngine;

public class TowerShoot : MonoBehaviour
{
    public List<GameObject> enemys = new List<GameObject>();
    public GameObject FishBullet_1;
    public float speed = 16f;
    private float attackTimer = 0f;
    private int i;
    void OnEnable()
    {
        EnemyList.EnemyList_The1 += EnemyList_;
    }
    void OnDisable()
    {
        EnemyList.EnemyList_The1 -= EnemyList_;
    }
    void Update()
    {
        attackTimer += Time.deltaTime;
        enemys.RemoveAll(enemy => enemy == null);
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
                spawnFishAttack.GetComponent<FishAttack_1>().Initialize(WhatEnemyIsTheClosest().transform);
            }
        }
        if (gameObject.tag == "BaseTower_2")
        {
            //switch statment

            if (attackTimer >= 0.4f)
            {
                attackTimer = 0f;
                GameObject spawnFishAttack = Instantiate(FishBullet_1, transform.position, Quaternion.identity);
                spawnFishAttack.GetComponent<FishAttack_1>().Initialize(WhatEnemyIsTheClosest().transform);
            }
        }
        Vector3 direction = WhatEnemyIsTheClosest().transform.position - transform.position;
        transform.right = -direction.normalized;
    }
    public void EnemyList_(GameObject enemy)
    {
        enemys.Add(enemy);
    }

    public GameObject WhatEnemyIsTheClosest()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemys)
        {
            if (enemy == null)
            {
                continue;
            }
            float distance = Vector2.Distance(transform.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }
        return closestEnemy;
    }

    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.CompareTag("Enemy"))
    //     {
    //         enemys.Add(collision.gameObject);
    //         //een for loop gebruiken.
    //     }
    // }
    // void OnTriggerExit2D(Collider2D collision)
    // {
    //     if (collision.CompareTag("Enemy"))
    //     {
    //         enemys.Remove(collision.gameObject);
    //     }
    // }
}
