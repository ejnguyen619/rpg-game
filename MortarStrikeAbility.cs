using UtilityEngine;
using System.Collections;

// ability 2 of specialist class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called MortarStrikeAbility.cs
// Marks target location and bombards a 5x5 area around it at start of next friendly phase

public class MortarStrikeAbility : Ability
{
    private const string aName = "Mortar Strike";
    private const string aDesc = "Marks target location and bombards a 5x5 area around it at start of next friendly phase";
    //private const Sprite icon = Resources.Load();
    private int initial_cd;
    private int cd;
    private float baseEffectDamage;

    // ranged, at the start, do not require target
    public MortarStrikeAbility(int CD, float BaseDam): base(new BasicObjectInformation(aName, aDesc)){
       //this.AbilityBehaviors.Add(new Ranged(10f,20f));
       initial_cd = 1;
       cd = CD;
       baseEffectDamage = BaseDam;
       this.AbilityBehaviors.Add(new AreaOfEffect(6f, 2f, baseEffectDamage));
    }

//-----------------------------------------------

    public int InitialCooldown
    {
        get { return initial_cd; }
        set { initial_cd = value; }
    }

    public int Cooldown
    {
        get { return cd; }
        set { cd = value; }
    }

    public float BaseDamage
    {
        get { return baseEffectDamage; }
        set { baseEffectDamage = value; }
    }

}

