using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public PlayerControllerv1 movement;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            TakeDamage(20);
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Collision detected");
        if (collisionInfo.collider.tag == "Enemy")
        {
            TakeDamage(20);
            Debug.Log("Collided with Enemy");

            if  (currentHealth == 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }

    }

    void TakeDamage(int damage)
    {
        // Updates current health to reflect the damage taken
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

    }
}
