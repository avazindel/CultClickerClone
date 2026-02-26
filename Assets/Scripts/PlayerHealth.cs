using UnityEngine;
using UnityEngine UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;

    public Slider slider;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (healthBar == null) return;
        if (healthBar.value <= 0f) return;

        healthBar.value -= drainPerSecond * Time.deltaTime;



        
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
