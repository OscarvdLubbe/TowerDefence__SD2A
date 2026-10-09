using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using Unity.Mathematics;
public class TowerPlacer : MonoBehaviour
{
    public Tilemap placementMap;
    public Tilemap nonPlacementMap;
    public GameObject ghostPrefab;
    private HashSet<Vector3Int> occupiedTiles = new HashSet<Vector3Int>();
    private GameObject ghostInstace;
    void Update()
    {
        handlePlacementHover();
        handlePlacementClickr();
    }
    void handlePlacementHover()
    {
        if (TowerSelectionUI.selectedTowerPrefefab == null)
        {
            if(ghostInstace != null)
                Destroy(ghostInstace);
            return;
        }
        if(ghostInstace == null)
            ghostInstace = Instantiate(ghostPrefab);
            
        ghostInstace.GetComponent<SpriteRenderer>().sprite = (TowerSelectionUI.selectedTowerPrefefab).GetComponent<SpriteRenderer>().sprite;

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0F;

        Vector3Int cellpos = placementMap.WorldToCell(mouseWorldPos);

        Vector3 worldCenter = placementMap.GetCellCenterWorld(cellpos);
        worldCenter.z = 0f;

        ghostInstace.transform.position = worldCenter + new Vector3(0, placementMap.cellSize.y) * 0.25f;

        bool valid = placementMap.HasTile(cellpos)&& !occupiedTiles.Contains(cellpos);

        ghostInstace.GetComponent<ghosttower>().SetValid(valid);
    }
    void handlePlacementClickr()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if(TowerSelectionUI.selectedTowerPrefefab == null)return;

        if (EventSystem.current != null && EventSystem.current.IsPointerOverGameObject())
            return;

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0F;

        Vector3Int cellpos = placementMap.WorldToCell(mouseWorldPos);

        if(placementMap.HasTile(cellpos)) return;
        if(occupiedTiles.Contains(cellpos)) return;

        Instantiate(TowerSelectionUI.selectedTowerPrefefab,ghostInstace.transform.position,Quaternion.identity);

        TowerSelectionUI.selectedTowerPrefefab = null;

        occupiedTiles.Add(cellpos);
    }
}
