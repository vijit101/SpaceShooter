using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class Asteroid : MonoBehaviour
{
    public string asteriodName;
    public Sprite asteroidSprite;
    public int AsteroidHP;
    public GameObject coinPrefab;

    public void SetValuefromScriptabletoAsteroid(AsteroidScriptable AsteroidScriptableobj)
    {
        asteriodName = AsteroidScriptableobj.asteriodName;
        AsteroidHP = AsteroidScriptableobj.asteriodHP;
        asteroidSprite = AsteroidScriptableobj.asteroidSprite;
        coinPrefab = AsteroidScriptableobj.coinPrefab;

    }

    public GameObject InstantiateAsteroid(AsteroidScriptable Asteroidscriptableobj)
    {

        GameObject InstantedGameObj = new GameObject();
        Asteroid AsteroidComponent = InstantedGameObj.AddComponent<Asteroid>();
        AsteroidComponent.SetValuefromScriptabletoAsteroid(Asteroidscriptableobj);
        InstantedGameObj.name = Asteroidscriptableobj.name;
        InstantedGameObj.transform.localScale = new Vector3(.2f, .2f, .2f);
        InstantedGameObj.AddComponent<BoxCollider2D>();
        //InstantedGameObj.AddComponent<BoxCollider>();
        Rigidbody2D rgbd = InstantedGameObj.AddComponent<Rigidbody2D>();
        rgbd.gravityScale = 0;
        //Debug.Log(AsteroidComponent["isflying"].ToString());
        if (AsteroidComponent.asteroidSprite != null)
        {
            SpriteRenderer spriteRenderer = AsteroidComponent.gameObject.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = Asteroidscriptableobj.asteroidSprite;
        }
        return InstantedGameObj;
    }



}
