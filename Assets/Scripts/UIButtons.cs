using System;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    public GameObject TowerselectionUI;
    //public GameObject Tower1;
    public event Action PlaceTower1;
    public static event Action NextWave;
    void Start()
    {
        TowerselectionUI.SetActive(false);
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
}
