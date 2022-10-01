using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : StaticInstance<PlayerManager>
{
    public int playerHP;
    public int playerMP;
    public int playerSP;

    [Space]
    public HealthBar healthBar;
    public StaminaBar staminaBar;
    public ManaBar manaBar;

    void Start()
    {
        Player.health = Player.maxHp = playerHP;
        Player.mana = Player.maxMp = playerMP;
        Player.stamina = Player.maxSp = playerSP;

        healthBar.Set(playerHP);
        manaBar.Set(playerMP);
        staminaBar.Set(playerSP);

    }

    void Update()
    {
        

    }

    public void AddHp(int hp) => ChangeStat(StatType.Health, hp);
    public void AddMp(int mp) => ChangeStat(StatType.Mana, mp);
    public void AddSp(int sp) => ChangeStat(StatType.Stamina, sp);

    public void ChangeStat(StatType type, int amount)
    {
        switch (type)
        {
            case StatType.Health:
                playerHP += amount;
                if (playerHP > Player.maxHp)
                    playerHP = Player.maxHp;
                Player.health = playerHP;
                healthBar.Set(playerHP);

                break;
            case StatType.Mana:
                playerMP += amount;
                if (playerMP > Player.maxMp)
                    playerMP = Player.maxMp;
                Player.mana = playerMP;
                manaBar.Set(playerMP);

                break;
            case StatType.Stamina:
                playerSP += amount;
                if (playerMP > Player.maxSp)
                    playerMP = Player.maxSp;
                Player.stamina = playerSP;
                staminaBar.Set(playerSP);

                break;
        }
    }

    public void GetHurt(int amount)
    {
        if (amount > Player.health) return;
    }

}

public enum StatType
{
    Health,
    Mana,
    Stamina
}

public static class Player
{
    public static int health;
    public static int maxHp;
    public static int mana;
    public static int maxMp;
    public static int stamina;
    public static int maxSp;
}
