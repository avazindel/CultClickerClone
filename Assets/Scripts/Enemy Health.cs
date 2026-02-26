using UnityEngine;
using UnityEngine UI;

public class EnemyHealth : MonoBehaviour
{

    public Slider slider;

    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar heathBar;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current.SpaceKey.WasPressedThisFrame)
        {
            TakeDamage(20);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);



    }



}
