using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    [Header("health status")]
    public int health = 100;
    public int maxHealth = 100;

    private void Start()
    {
        DisplayCharacterSheet();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            maxHealth += 20;
            health = maxHealth;
            Debug.Log("more health!");
            Debug.Log("health increased!");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            health = Mathf.Max(0, health - 10);
            Debug.Log("Health decreased! Health: " + health + "/" + maxHealth);
            if (health < 20)
            {
                Debug.Log("Critical: Very low health");
            }
            else if (health > 20)
            {
                Debug.Log("Warning: Low health");
            }
            if (health > 50)
            {
                Debug.Log("Good health");
            }
            else if (health > 80)
            {
                Debug.Log("Excellent health");
            }
        }
        
         
    }

    private void minhealth()
    {
        health = Mathf.Max(0, health - 10);
    }

    private void DisplayCharacterSheet()
    {
        Debug.Log($"Health: {health}/{maxHealth}");
    }
}
