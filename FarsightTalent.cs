using UtilityEngine;
using System.Collections;

// talent of recon class
// create new folder in Ability System called Talent 
// create new C# script in Talent called FarsightTalent.cs
// greatly increased sight range

public class FarsightTalent : BaseCharacterClass
{
    private int farsight_boost;

    public FarsightTalent(int sightup)
    {
        farsight_boost = sightup;
        SightRange += farsight_boost;
    }

    public int SightBoost
    {
        get { return farsight_boost; }
        set { farsight_boost = value; }
    }

}
