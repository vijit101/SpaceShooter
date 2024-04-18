using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour, IDamagable
{
    public float speed = 6;
    float clampx = 2.75f, horizontalValue, AttackTimer = 0;
    public Transform BulletSpawnpt;
    public GameObject BulletProjectile;
    public float timeBtwAttacks;
    bool canAttack;
    float Shiphp;
    
    public void SetHp(int hp )
    {
        this.Shiphp = hp;
    }

    public float GetHp()
    {
        return this.Shiphp;
    }

    private void Awake()
    {
        SetHp(1);
    }
    // Update is called once per frame
    void Update()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal");
        if (horizontalValue > 0 || horizontalValue < 0)
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * horizontalValue);
        }

        if (transform.position.x > clampx || transform.position.x < -clampx) {
           transform.position = new Vector3(Mathf.Clamp(transform.position.x, clampx, -clampx), transform.position.y,transform.position.z);
        }
        Attack();
        

        
        
    }


    public void Attack()
    {
        AttackTimer += Time.deltaTime;
        if(AttackTimer > timeBtwAttacks)
        {
            canAttack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (canAttack) {
                GameObject projectile = Instantiate(BulletProjectile);
                projectile.transform.position = BulletSpawnpt.position;
                canAttack = false;
                AttackTimer = 0;

                // play sound effects 
            }
        }
    }

    public void TakeDamage(int Damage)
    {
        Shiphp -= Damage;
        if (Shiphp < 0) {
            Debug.Log("GameOver");
            Destroy(this.gameObject);
        }
    }
}
