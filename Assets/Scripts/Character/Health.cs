using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] protected float health;
    [SerializeField] protected float maxHealth = 100f;

    void Awake()
    {
        health = maxHealth;
    }

    public void UpdateHealth(float mod)
	{
        health += mod;
        //if health <= 0 Throw onDeath Event
        if(health <= 0) {
            health = 0;
            onDeath();
		}
	}

    public float GetHealth() {
        return health;
	}
    public float GetMaxHealth() {
        return maxHealth;
    }
    protected virtual void onDeath() {
        Destroy(this.gameObject);
	}
}
