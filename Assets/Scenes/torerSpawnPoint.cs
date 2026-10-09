using UnityEngine;

public class torerSpawnPoint : MonoBehaviour
{
    public GameObject TowerselectionUI;
    //public GameObject closeTowerSelectionUIbuttor;
    void Start()
    {
        TowerselectionUI.SetActive(false);
    }
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("click detection");
        //     TowerselectionUI.SetActive(true);
        // }
    }
    public void closeTowerUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TowerselectionUI.SetActive(false);
        }
    }
}
