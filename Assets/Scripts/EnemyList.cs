using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyList : MonoBehaviour
{
    public static event Action<GameObject> EnemyList_The1;
    void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyList_The1?.Invoke(collision.gameObject);
    }
    //dit stuur ik naar de towershoot en daar berekene ik de afstand tussen de tower en de enemys. en dan attackt hij de dichtbijzijnde
}
