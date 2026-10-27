using UnityEngine;

public class WhatPathTheEnemyTake : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Transform[][] Paths;
    
    [SerializeField] private Transform[] path1;
    [SerializeField] private Transform[] path2;
    [SerializeField] private Transform[] path3;
    [SerializeField] private Transform[] path4;
    [SerializeField] private Transform[] path5;
    public void Init(Transform[] Point)
    {
        Paths = new Transform[][]
        {
            path1,
            path2,
            path3,
            path4,
            path5  
        };
        path1 = Point;
        path2 = Point;
        path3 = Point;
        path4 = Point;
        path5 = Point;
    }
}