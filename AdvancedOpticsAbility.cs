using UtilityEngine;
using System.Collections;

// ability 1 of recon class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called AdvancedOpticsAbility.cs
// Increases sight range by 3

public class AdvancedOpticsAbility : BaseCharacterClass
{

    public AdvancedOpticsAbility()
    {
        SightRange += 3;
    }

}
