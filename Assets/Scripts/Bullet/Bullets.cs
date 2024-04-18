using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float bulletSpeed,yBound;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed * Vector2.up*Time.deltaTime);
        if (transform.position.y > yBound)
        {
            Destroy(gameObject);
        }
    }


}
