using UnityEngine;
using UnityEngine UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;

    public Slider slider;

    public int currentHealth;
    public HealthBar healthBar;

    public float damagePerSecond = 1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;


    }

    // Update is called once per frame
    void Update()
    {

        if (healthBar == null) return;
        if (healthBar.value > maxHealth) value = maxHealth;

        healthBar.value -= damagePerSecond * Time.deltaTime;



        
    }

    public void setHealth(int health)
    {
        slider.value = health;
    }

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }




}
