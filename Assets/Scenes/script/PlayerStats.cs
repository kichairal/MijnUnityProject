using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
//Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";
    public string friendStatus = "you got no friends";
    public float height = 1.75f;
    //add your own stats here

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 25;
    public int defense = 15;
    public int happyness = 75;
    public string healthStatus = "normal health";

    //add your own stats here

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    public bool hasDefeatedBoss = false;
    public bool hasFoundSecretItem = false;
    //add your own stats here

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";
    public int bandages = 5;
    public int shields = 2;

    void Start()
    {
        DisplayCharacterSheet();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            level++;
            maxHealth += 20;
            health = maxHealth;
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health = Mathf.Min(health + 30, maxHealth);
                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetStats();
        }
    }

    private void showCharacterSheet()
    {
        throw new NotImplementedException();
    }

    private void ResetStats()
    {
        level = 1;
        health = 100;
        maxHealth = 100;
        mana = 50;
        attack = 25;
        defense = 15;
        experience = 0;
        gold = 150;
        healthPotions = 3;
        keys = 1;
        currentWeapon = "Iron Sword";
        playerName = "noob";
        Debug.Log("Stats reset!");
        DisplayCharacterSheet();
    }

    private void DisplayCharacterSheet()
    {
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}

    