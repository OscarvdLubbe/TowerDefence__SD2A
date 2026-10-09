using System;
using UnityEngine;

public class TowerSpawnScript : MonoBehaviour
{
    public GameObject TowerselectionUI;
    public static event Action WereToPlaceTower_1;
    public static event Action WereToPlaceTower_2;
    public static event Action WereToPlaceTower_3;
    public static event Action WereToPlaceTower_4;
    public static event Action WereToPlaceTower_5;
    public static event Action WereToPlaceTower_6;
    void OnEnable()
    {

    }
    void OnDisable()
    {
        //UIButtons.
    }
    private void OnMouseDown()
    {
        TowerselectionUI.SetActive(true);
        string clickedTag = gameObject.tag;
       
        Debug.Log("Clicked object tag is: " + clickedTag);

        if (gameObject.tag == "TowerSpawn_1")
            WereToPlaceTower_1?.Invoke();
            
        if (gameObject.tag == "TowerSpawn_2")
            WereToPlaceTower_2?.Invoke();

        if (gameObject.tag == "TowerSpawn_3")
            WereToPlaceTower_3?.Invoke();

        if (gameObject.tag == "TowerSpawn_4")
            WereToPlaceTower_4?.Invoke();

        if (gameObject.tag == "TowerSpawn_5")
            WereToPlaceTower_5?.Invoke();

        if (gameObject.tag == "TowerSpawn_6")
            WereToPlaceTower_6?.Invoke();
    }
}
