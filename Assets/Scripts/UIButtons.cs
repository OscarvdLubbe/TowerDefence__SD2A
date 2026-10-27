using System;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    public GameObject UpgardeMenuTower_1;
    // public GameObject UpgardeMenuTower_2;
    // public GameObject UpgardeMenuTower_3;
    public GameObject TowerselectionUI;
    //public GameObject Tower1;
    public event Action PlaceTower1;
    public static event Action NextWave;
    void Start()
    {
        TowerselectionUI.SetActive(false);

        UpgardeMenuTower_1.SetActive(false);
        // UpgardeMenuTower_2.SetActive(false);
        // UpgardeMenuTower_3.SetActive(false);
    }
    public void closeTowerUI()
    {
        TowerselectionUI.SetActive(false);
    }
    public void OnPlaceTower1()
    {
        PlaceTower1?.Invoke();
    }
    public void StartNextWave()
    {
        NextWave?.Invoke();
    }

    public void OnOpeneUpgradeMenu_1()
    {
        // UpgardeMenuTower_2.SetActive(false);
        // UpgardeMenuTower_3.SetActive(false);

        UpgardeMenuTower_1.SetActive(true);
    }
    public void OnOpeneUpgradeMenu_2()
    {
        UpgardeMenuTower_1.SetActive(false);
        // UpgardeMenuTower_3.SetActive(false);

        // UpgardeMenuTower_2.SetActive(true);
    }
    public void OnOpeneUpgradeMenu_3()
    {
        UpgardeMenuTower_1.SetActive(false);
        // UpgardeMenuTower_2.SetActive(false);

        // UpgardeMenuTower_3.SetActive(true);
    }
    public void CloseUpgradeMenu()
    {
        UpgardeMenuTower_1.SetActive(false);
        // UpgardeMenuTower_2.SetActive(false);
        // UpgardeMenuTower_3.SetActive(false);
    }
}
