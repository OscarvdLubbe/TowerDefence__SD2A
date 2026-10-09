using System.Collections;
using System.Linq;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class Waves : MonoBehaviour
{
    [Header("Paths")]
    public Transform[] Path_1;
    public Transform[] Path_2;

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
    void Update()
    {
        text.text = $"{EnemyWaves}/10";
    }
    IEnumerator EnemySpawnInWaves()
    {
        switch (EnemyWaves)
        {
            case 1: //wave 1 etc...
                for (int i = 0; i < 10; i++)
                {
                    Enemy1Spawning();
                    yield return new WaitForSeconds(1f);
                }
                break;

            case 2:
                for (int i = 0; i < 5; i++)
                {
                    Enemy1Spawning();
                    yield return new WaitForSeconds(0.5f);

                    Enemy2Spawning();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
                //set allen enemys in een list en als de list leeg is mag je volgende ronde starten 
        }
    }
    void Enemy1Spawning()
    {
        GameObject enemy = Instantiate(normalBirdEnemy_1, EnemyStartPoint.position, EnemyStartPoint.rotation);
        enemyScript enemyscript = enemy.GetComponent<enemyScript>(); 
        enemyscript.Init(Path_1);
    }
    void Enemy2Spawning()
    {
        GameObject enemy = Instantiate(coolBirdEnemy_2, EnemyStartPoint.position, EnemyStartPoint.rotation);
        enemyScript enemyscript = enemy.GetComponent<enemyScript>(); 
        enemyscript.Init(Path_1);
    }
    void DoingNextWave()
    {
        EnemyWaves++;
        Debug.Log("Doing next wave " + $"EnemyWave = {EnemyWaves}");
        StartCoroutine(EnemySpawnInWaves());
        // Debug.LogError("This does not work");
        // Debug.LogError("Fix it");
    }
}
