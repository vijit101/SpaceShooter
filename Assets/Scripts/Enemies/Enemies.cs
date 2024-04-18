using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour,IDamagable
{
    public int Damage = 1;
    public int hp = 1;

    public void TakeDamage(int Damage)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        IDamagable damagableInterface = collision.gameObject.GetComponent<IDamagable>();
        if (damagableInterface != null)
        {
            damagableInterface.TakeDamage(Damage);

            if (hp < 0) {

                Destroy(this.gameObject);
            }
        }
    }

    
}
