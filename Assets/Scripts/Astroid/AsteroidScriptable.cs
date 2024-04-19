using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Animal", menuName = "Scriptables/Animal")]
public class AsteroidScriptable : ScriptableObject
{
    public string asteriodName;
    public Sprite asteroidSprite;
    //public Animal AnimalView;
    public int asteriodHP;
    public GameObject coinPrefab;

}
