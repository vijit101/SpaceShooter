using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    public float ScrollSpeed = 0.1f;
    private MeshRenderer meshRenderer;
    public List<Texture2D> textures;
    float yScroll;
    float timer = 8;
    // Start is called before the first frame update
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ScrollBg();
    }

    private void ScrollBg()
    {
        yScroll += Time.deltaTime * ScrollSpeed;
        Vector2 offset = new Vector2 (0, yScroll);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);

        if(timer <= 0)
        {
            timer = 8;
            int randomNum = UnityEngine.Random.Range(0, textures.Count);
            meshRenderer.sharedMaterial.SetTexture("_MainTex",textures[randomNum]);
        }
        timer -= Time.deltaTime;
    }

    
}
