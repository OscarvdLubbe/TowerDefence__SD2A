using TMPro;
using UnityEngine;

public class CoinManagmentSystem : MonoBehaviour
{
    private int startingCash = 100;
    private int CoinAmount = 0;
    private int Enemy_1_Death = 10;
    private int Enemy_2_Death = 20;
    private int Enemy_3_Death = 50;
    private int Tower_1_cost = 50;
    private int Tower_2_cost = 100;
    private int Tower_3_cost = 250;
    [Header("UI")]
    public TextMeshProUGUI text;
    void OnEnable()
    {
        Enemy_1.Enemy_1_Dead += Enemy_1_Dies;
        Enemy_2.Enemy_2_Dead += Enemy_2_Dies;
        TowerspawnUI.SpawnTower_1 += BuyTower_1;
    }
    void OnDisable()
    {
        Enemy_1.Enemy_1_Dead -= Enemy_1_Dies;
        Enemy_2.Enemy_2_Dead -= Enemy_2_Dies;
        TowerspawnUI.SpawnTower_1 -= BuyTower_1;
    }
    void Start()
    {
        CoinAmount = startingCash;
    }

    // Update is called once per frame
    void Update()
    {
        startingCash += CoinAmount;
        text.text = $"{CoinAmount}";
    }
    public void Enemy_1_Dies()
    {
        CoinAmount += Enemy_1_Death;
    }
    public void Enemy_2_Dies()
    {
        CoinAmount += Enemy_2_Death;
    }
    public void Enemy_3_Dies()
    {
        CoinAmount += Enemy_3_Death;
    }



    public void BuyTower_1()
    {
        CoinAmount -= Tower_1_cost;
    }
    public void BuyTower_2()
    {
        CoinAmount -= Tower_2_cost;
    }
    public void BuyTower_3()
    {
        CoinAmount -= Tower_3_cost;
    }
}