using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    public GameObject UpgardeMenuTower_1;
    // public GameObject UpgardeMenuTower_2;
    // public GameObject UpgardeMenuTower_3;
    void Start()
    {
        UpgardeMenuTower_1.SetActive(false);
        //UpgardeMenuTower_2.SetActive(false);
        //UpgardeMenuTower_3.SetActive(false);
    }

    public void OnOpeneUpgradeMenu_1()
    {
        //UpgardeMenuTower_2.SetActive(false);
        //UpgardeMenuTower_3.SetActive(false);

        UpgardeMenuTower_1.SetActive(true);
    }
    public void OnOpeneUpgradeMenu_2()
    {
        UpgardeMenuTower_1.SetActive(false);
        //pgardeMenuTower_3.SetActive(false);

        //UpgardeMenuTower_2.SetActive(true);
    }
    public void OnOpeneUpgradeMenu_3()
    {
        UpgardeMenuTower_1.SetActive(false);
        //UpgardeMenuTower_2.SetActive(false);

        //UpgardeMenuTower_3.SetActive(true);
    }
    public void CloseUpgradeMenu()
    {
        UpgardeMenuTower_1.SetActive(false);
        //UpgardeMenuTower_2.SetActive(false);
        //UpgardeMenuTower_3.SetActive(false);
    }
}
