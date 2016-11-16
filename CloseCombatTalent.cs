using UtilityEngine;
using System.Collections;

// talent of assault class
// create new folder in Ability System called Talent 
// create new C# script in Talent called CloseCombatTalent.cs
// adjacent enemies take +2 damage from basic attacks

public class CloseCombatTalent : BaseCharacterClass
{
    private bool target_adjacent;
    private int temp_wpn1_dmg;
    private int temp_wpn2_dmg;

    public CloseCombatTalent()
    {
        target_adjacent = false;
    }

    public void activateCloseCombat()
    {
        if (target_adjacent) {
            restoreValues();
            storeValues();
            Weapon1Damage += 2;
            Weapon2Damage += 2;
        }
        else { restoreValues(); }
    }

    public void storeValues()
    {
        temp_wpn1_dmg = Weapon1Damage;
        temp_wpn2_dmg = Weapon2Damage;
    }

    // default base stats. Revert after conditions of ability no longer apply.
    public void restoreValues()
    {
        Weapon1Damage = temp_wpn1_dmg;
        Weapon2Damage = temp_wpn2_dmg;
    }

    public bool targetIsAdjacent
    {
        get { return target_adjacent; }
        set { target_adjacent = value; }
    }

    public int ReadWeapon1Damage
    {
        get { return temp_wpn1_dmg; }
        set { temp_wpn1_dmg = value; }
    }

    public int ReadWeapon2Damage
    {
        get { return temp_wpn2_dmg; }
        set { temp_wpn2_dmg = value; }
    }


}
