using UtilityEngine;
using System.Collections;

// ability 1 of specialist class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called FragGrenadeAbility.cs
// Explodes in a 3x3 area around the target point

public class FragGrenadeAbility: Ability {
 
   private const string aName = "Frag Grenade";
   private const string aDesc = "Explodes in a 3x3 area around the target point";
   //private const Sprite icon = Resources.Load();
   private int initial_cd;
   private int cd;
   private float baseEffectDamage;
 
   // ranged, at the start, do not require target
   public FragGrenadeAbility(int CD, float BaseDam) : base(new BasicObjectInformation(aName, aDesc)){
      //this.AbilityBehaviors.Add(new Ranged(10f,20f));
      initial_cd = 0;
      cd = CD;
      baseEffectDamage = BaseDam;
      this.AbilityBehaviors.Add(new AreaOfEffect(3f,2f,baseEffectDamage));
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