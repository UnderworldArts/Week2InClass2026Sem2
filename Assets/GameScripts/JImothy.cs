using UnityEngine;

public class JImothy : Damageable
{
    [SerializeField] int hp;



    public void TakeDamage(int damageAmount)
    {
        hp -= damageAmount;
        if (hp <= 0)
        {
            Dead();
        }
    }



    public void Dead()
    {
        Debug.Log("Dead");
    }
}
