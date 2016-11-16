using UtilityEngine;
using System.Collections;

// ability 1 of assault class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called ExecutionerAbility.cs
// increase damage dealt to damaged characters by 1

public class ExecutionerAbility: BaseCharacterClass
{
    public ExecutionerAbility()
    {
        Weapon1Damage += 1;
        Weapon2Damage += 1;
    }

}
