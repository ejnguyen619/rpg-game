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

    public OpportunistTalent()
    {
        cd_reduce = 0;
        target_hit = false;
    }

    public void activateOpportunity(FragGrenadeAbility afragren, MortatStrikeAbility amort, int acd_loss)
    {
        if (incover) {
            cd_reduce = acd_loss;
            afragren.Cooldown = afragren.Cooldown - cd_reduce;
            amort.Cooldown = amort.Cooldown - cd_reduce;
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
