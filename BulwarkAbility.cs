using UtilityEngine;
using System.Collections;

// ability 2 of heavy class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called BulwarkAbility.cs
// Increase damage mitigation by 1 (to 3) while in cover

public class BulwarkAbility : BaseCharacterClass
{
    private bool incover;
    // store damage values before Double Edge takes effect
    // includes elevation and cover effects
    private int temp_dmg_mitig;

    public BulwarkAbility()
    {
        incover = false;
    }

    public void activateBulwark()
    {
        if (incover) {
            restoreValues();
            storeValues();
            DamageMitigation += 1;
        }
        else { restoreValues(); }
    }

    public void storeValues()
    {
        temp_dmg_mitig = DamageMitigation;
    }

    // default base stats. Revert after conditions of ability no longer apply.
    public void restoreValues()
    {
        DamageMitigation = temp_dmg_mitig;
    }


    public bool inCover
    {
        get { return incover; }
        set { incover = value; }
    }

    public int ReadDamageMitigation
    {
        get { return temp_dmg_mitig; }
        set { temp_dmg_mitig = value; }
    }

}
