using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class TowerspawnUI : MonoBehaviour
{
    [Header("diffirent types of placable Towers")]
    public GameObject Tower_1;
    public GameObject Tower_2;

    [Header("TowerSpawnLocations")]
    public GameObject[] SpawnLocation;
    // public GameObject SpawnLocation_1;
    // public GameObject SpawnLocation_2;
    // public GameObject SpawnLocation_3;
    // public GameObject SpawnLocation_4;
    // public GameObject SpawnLocation_5;
    // public GameObject SpawnLocation_6;

    [Header("Possible spawn locations")]
    public GameObject[] TowerLocations;
    private int i;
    private int j;

    [Header("UI")]
    public GameObject towerSpawnUI_1;

    void OnEnable()
    {
        TowerSpawnScript.WereToPlaceTower_1 += SpawnPoint_1;
        TowerSpawnScript.WereToPlaceTower_2 += SpawnPoint_2;
        TowerSpawnScript.WereToPlaceTower_3 += SpawnPoint_3;
        TowerSpawnScript.WereToPlaceTower_4 += SpawnPoint_4;
        TowerSpawnScript.WereToPlaceTower_5 += SpawnPoint_5;
        TowerSpawnScript.WereToPlaceTower_6 += SpawnPoint_6;
    }
    void OnDisable()
    {
        TowerSpawnScript.WereToPlaceTower_1 -= SpawnPoint_1;
        TowerSpawnScript.WereToPlaceTower_2 -= SpawnPoint_2;
        TowerSpawnScript.WereToPlaceTower_3 -= SpawnPoint_3;
        TowerSpawnScript.WereToPlaceTower_4 -= SpawnPoint_4;
        TowerSpawnScript.WereToPlaceTower_5 -= SpawnPoint_5;
        TowerSpawnScript.WereToPlaceTower_6 -= SpawnPoint_6;
    }
    public void spawnTower_1()
    {
        Instantiate(Tower_1, TowerLocations[i].transform.position, quaternion.identity);
        SpawnLocation[j].SetActive(false);
        towerSpawnUI_1.SetActive(false);
        //chosenTower.SetActive(false);
    }
    public void spawnTower_2()
    {
        Instantiate(Tower_2, TowerLocations[i].transform.position, quaternion.identity);
        SpawnLocation[j].SetActive(false);
        towerSpawnUI_1.SetActive(false);
    }

    public void SpawnPoint_1()
    {
        i = 0;
        j = 0;
    }
    public void SpawnPoint_2()
    {
        i = 1;
        j = 1;
    }
    public void SpawnPoint_3()
    {
        i = 2;
        j = 2;
    }
    public void SpawnPoint_4()
    {
        i = 3;
        j = 3;
    }
    public void SpawnPoint_5()
    {
        i = 4;
        j = 4;
    }
    public void SpawnPoint_6()
    {
        i = 5;
        j = 5;
    }
}