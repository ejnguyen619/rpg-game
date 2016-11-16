using UtilityEngine;
using System.Collections;

// talent of heavy class
// create new folder in Ability System called Talent 
// create new C# script in Talent called OverkillTalent.cs
// basic attacks deal +2 damage to enemies out of cover

public class OverkillTalent : BaseCharacterClass
{
    private bool target_incover;
    private int temp_wpn1_dmg;
    private int temp_wpn2_dmg;

    public OverkillTalent()
    {
        target_incover = false;
    }

    public void activateOverkill()
    {
        if (incover == false) {
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

    public bool targetIsInCover
    {
        get { return target_incover; }
        set { target_incover = value; }
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
