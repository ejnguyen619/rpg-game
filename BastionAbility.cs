using UtilityEngine;
using System.Collections;

// new ability 1 of heavy class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called BastionAbility.cs
// Increases damage by 1 while in cover

public class BastionAbility : BaseCharacterClass
{

    private bool incover;
    private int temp_wpn1_dmg;
    private int temp_wpn2_dmg;

    public BastionAbility() 
    {
        incover = false;
    }

    public void activateBastion()
    {
        if (incover)
        {
            restoreValues();
            storeValues();
            Weapon1Damage += 1;
            Weapon2Damage += 1;
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

    public bool inCover
    {
        get { return incover; }
        set { incover = value; }
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