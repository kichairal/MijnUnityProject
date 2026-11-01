using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public string CurrentWeapon { get; private set; } = "sword";
    public int CurrentDamage { get; private set; } = 25;
    public float CurrentSpeed { get; private set; } = 10f;

    private PlayerStats playerStats;

    private void Awake()
    {
        playerStats = GetComponent<PlayerStats>();
        ApplyWeaponStats();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeapon("sword", 25, 10f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetWeapon("bow", 20, 1.5f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetWeapon("staff", 35, 0.7f);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetWeapon("dagger", 15, 2f);
        }
    }

    private void SetWeapon(string weapon, int damage, float speed)
    {
        CurrentWeapon = weapon;
        CurrentDamage = damage;
        CurrentSpeed = speed;
        ApplyWeaponStats();
        Debug.Log($"Equipped {CurrentWeapon}: damage {CurrentDamage}, speed {CurrentSpeed}");
    }

    private void ApplyWeaponStats()
    {
        if (playerStats == null)
        {
            return;
        }

        playerStats.currentWeapon = CurrentWeapon;
        playerStats.attack = CurrentDamage;
    }
}
