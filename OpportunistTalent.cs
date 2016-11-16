using UtilityEngine;
using System.Collections;

// talent of specialist class
// create new folder in Ability System called Talent 
// create new C# script in Talent called OpportunistTalent.cs
// basic attacks reduce cooldown of abilities

public class OpportunistTalent : Ability
{
    private bool target_hit;
    private int cd_reduce;
    private FragGrenadeAbility fragren;
    private MortarStrikeability mort;

    public OpportunistTalent(FragGrenadeAbility afragren, MortatStrikeAbility amort, int acd_loss)
    {
        cd_reduce = acd_loss;
        target_hit = false;
        fragren = afragren;
        mort = amort;
    }

    public void activateOpportunity()
    {
        if (incover) {
            fragren.Cooldown = fragren.Cooldown - cd_reduce;
            mort.Cooldown = mort.Cooldown - cd_reduce;
        }
    }

    public bool targetHit
    {
        get { return target_hit; }
        set { target_hit = value; }
    }

    public int CooldownReduce
    {
        get { return cd_reduce; }
        set { cd_reduce = value; }
    }

}
