using System.Collections;
//using System.Linq;
using TMPro;
//using Unity.Mathematics;
using UnityEngine;

public class Waves : MonoBehaviour
{
    [Header("Paths")]
    public Transform[] Path_1;
    public Transform[] Path_2;
    public Transform[] Path_3;
    public Transform[] Path_4;
    public Transform[] Path_5;
    private Transform[][] Paths;

    [Header("Enemys")]
    public GameObject normalBirdEnemy_1;
    public GameObject coolBirdEnemy_2;
    public Transform EnemyStartPoint;

    [Header("UI")]
    public TextMeshProUGUI text;
   
    private int EnemyWaves;
    // action event om wave counter omhoog te laten gaan als je er op klikt in UI script

    void OnEnable()
    {
        UIButtons.NextWave += DoingNextWave;
    }

    void OnDisable()
    {
        UIButtons.NextWave -= DoingNextWave;
    }
    void Start()
    {
        Paths = new Transform[][]
        {
            Path_1,
            Path_2,
            Path_3,
            Path_4,
            Path_5
        };
        
    }
    void Update()
    {
        text.text = $"{EnemyWaves}/20";
        
    }
    
IEnumerator EnemySpawnInWaves()
{
    switch (EnemyWaves)
    {
        case 1: // Wave 1
            for (int i = 0; i < 10; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(2f);
            }
            break;
        case 2: // Wave 2
            for (int i = 0; i < 10; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(1.5f);
            }
            break;
        case 3: // Wave 3
            for (int i = 0; i < 8; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(1.5f);
            }
            break;
        case 4: // Wave 4
            for (int i = 0; i < 10; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(1.3f);
                Enemy2Spawning();
                yield return new WaitForSeconds(1f);
            }
            break;
        case 5: // Wave 5
            for (int i = 0; i < 12; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(1.1f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.9f);
            }
            break;
        case 6: // Wave 6
            for (int i = 0; i < 14; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(1f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.8f);
            }
            break;
        case 7: // Wave 7
            for (int i = 0; i < 16; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.9f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.7f);
            }
            break;
        case 8: // Wave 8
            for (int i = 0; i < 18; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.8f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.6f);
            }
            break;
        case 9: // Wave 9
            for (int i = 0; i < 20; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.7f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.5f);
            }
            break;
        case 10: // Wave 10
            for (int i = 0; i < 22; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.6f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.45f);
            }
            break;
        case 11: // Wave 11
            for (int i = 0; i < 24; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.55f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.4f);
            }
            break;
        case 12: // Wave 12
            for (int i = 0; i < 27; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.5f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.35f);
            }
            break;
        case 13: // Wave 13
            for (int i = 0; i < 30; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.45f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.3f);
            }
            break;
        case 14: // Wave 14
            for (int i = 0; i < 34; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.4f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.28f);
            }
            break;
        case 15: // Wave 15
            for (int i = 0; i < 38; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.35f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.25f);
            }
            break;
        case 16: // Wave 16
            for (int i = 0; i < 43; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.3f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.22f);
            }
            break;
        case 17: // Wave 17
            for (int i = 0; i < 48; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.28f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.2f);
            }
            break;
        case 18: // Wave 18
            for (int i = 0; i < 54; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.25f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.18f);
            }
            break;
        case 19: // Wave 19
            for (int i = 0; i < 62; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.22f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.15f);
            }
            break;
        case 20: // Wave 20 - Final wave
            for (int i = 0; i < 75; i++)
            {
                Enemy1Spawning();
                yield return new WaitForSeconds(0.18f);
                Enemy2Spawning();
                yield return new WaitForSeconds(0.12f);
            }
            break;
    }
}

    void Enemy1Spawning()
    {
        int randomIndex = Random.Range(0, Paths.Length);
        Transform[] randomPathIndex = Paths[randomIndex];
        GameObject enemy = Instantiate(normalBirdEnemy_1, randomPathIndex[0].position, Quaternion.Euler(0,180f,90f));
        Enemy_1 EnemySpawn = enemy.GetComponent<Enemy_1>(); 
        EnemySpawn.Init(randomPathIndex);
    }
    void Enemy2Spawning()
    {
        int randomIndex = Random.Range(0, Paths.Length);
        Transform[] randomPathIndex = Paths[randomIndex];
        GameObject enemy = Instantiate(coolBirdEnemy_2, randomPathIndex[0].position, Quaternion.Euler(0,0f,90f));
        Enemy_1 EnemySpawn = enemy.GetComponent<Enemy_1>();
        EnemySpawn.Init(randomPathIndex);
    }
    void Enemy3Spawning()
    {
        int randomIndex = Random.Range(0, Paths.Length);
        Transform[] randomPathIndex = Paths[randomIndex];
        GameObject enemy = Instantiate(coolBirdEnemy_2, randomPathIndex[0].position, Quaternion.Euler(0,0f,90f));
        Enemy_1 EnemySpawn = enemy.GetComponent<Enemy_1>();
        EnemySpawn.Init(randomPathIndex);
    }
    void DoingNextWave()
    {
        EnemyWaves++;
        Debug.Log("Doing next wave " + $"EnemyWave = {EnemyWaves}");
        StartCoroutine(EnemySpawnInWaves());
    }
}