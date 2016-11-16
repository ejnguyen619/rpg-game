using UtilityEngine;
using System.Collections;

// ability 3 of assault class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called DominanceAbility.cs
// Restore 3 health per kill

public class DominanceAbility : BaseCharacterClass
{
    private int numberkills;
    private int max_health;

    public DominanceAbility()
    {
        numberkills = 0;
        max_health = 8;
    }

    public void addKill()
    {
        numberkills += 1;
        if (Health < max_health) { activateAbility(); }
    }

    public void activateDominance()
    {
        Health += 3;
        if (Health > max_health) { Health = 8; }
    }

    public int currentKills
    {
        get { return numberkills; }
        set { numberkills = value; }
    }

    public int maxHealth
    {
        get { return max_health; }
    }

}