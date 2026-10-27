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
        text.text = $"{EnemyWaves}/10";
        
    }
    IEnumerator EnemySpawnInWaves()
    {
        switch (EnemyWaves)
        {
            case 1: //wave 1 etc...
                for (int i = 0; i < 5; i++)
                {
                    Enemy1Spawning();
                    yield return new WaitForSeconds(3f);
                }
                break;

            case 2:
                for (int i = 0; i < 10; i++)
                {
                    Enemy1Spawning();
                    yield return new WaitForSeconds(1f);
                }
                break;
                //zet allen enemys in een list en als de list leeg is mag je volgende ronde starten 
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