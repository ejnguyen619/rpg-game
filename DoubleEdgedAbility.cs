using UtilityEngine;
using System.Collections;

// ability 2 of assault class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called DoubleEdgedAbility.cs
// Increase damage dealt to adjacent targets by 1, but no longer does damage to targets in cover

public class DoubleEdgedAbility : BaseCharacterClass
{
    private bool target_incover;
    private bool target_adjacent;

    // store damage values before Double Edge takes effect
    // includes elevation and cover effects
    private int temp_wpn1_dmg;
    private int temp_wpn2_dmg;

    public DoubleEdgedAbility()
    {
        target_incover = false;
        target_adjacent = false;
    }

    public void activateDoubleEdged()
    {
        if (target_adjacent) {
            restoreValues();
            Buff();
        }
        if (target_incover) {
            restoreValues();
            Debuff();
        }
        else { restoreValues(); }
    }

    public void Buff()
    {
        storeValues();
        Weapon1Damage += 1;
        Weapon2Damage += 1;
    }

    public void Debuff()
    {
        storeValues();
        Weapon1Damage = 0;
        Weapon2Damage = 0;
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

    public bool targetIsInCover
    {
        get { return target_incover; }
        set { target_incover = value; }
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
