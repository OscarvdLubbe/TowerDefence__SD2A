using UnityEngine;

public class TowerSelectionUI : MonoBehaviour
{
    public static GameObject selectedTowerPrefefab;

    public void selectTower(GameObject towerPrefab)
    {
        if (towerPrefab == selectedTowerPrefefab)
        {
            selectedTowerPrefefab = null;
            return;
        }
        selectedTowerPrefefab = towerPrefab;
    }
}
