using UtilityEngine;
using System.Collections;

// ability 2 of recon class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called CamperAbility.cs
// Increase weapon range by 2 and lose 1 movement speed

public class CamperAbility : BaseCharacterClass
{

    public CamperAbility()
    {
        Weapon1Range += 2;
        MovementSpeed -= 1;
    }

}
