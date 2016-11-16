using UtilityEngine;
using System.Collections;

// ability 3 of specialist class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called DestructiveAbility.cs
// Increase ability damage by 1, but increase cooldowns by 1 phase

public class DestructiveAbility
{
    // connect to other specialist abilities
    private FragGrenadeAbility fragren;
    private MortarStrikeAbility mort;

    // base cooldown and damage
    private int frag_cd;
    private int mortar_cd;
    private float frag_dam;
    private float mortar_dam;

    public DestructiveAbility()
    {
        frag_cd = 3;
        mortar_cd = 6;
        frag_dam = 3f;
        mortar_dam = 6f;
        fragren = new FragGrenadeAbility(frag_cd + 1, frag_dam + 1f);
        mort = new MortarStrikeAbility(mortar_cd + 1, mortar_dam + 1f);
    }

    public int FragCoolDown
    {
        get { return frag_cd; }
        set { frag_cd = value; }
    }

    public int MortarCoolDown
    {
        get { return mortar_cd; }
        set { mortar_cd = value; }
    }

    public float FragDamage
    {
        get { return frag_dam; }
        set { frag_dam = value; }
    }

    public float MortarDamage
    {
        get { return mortar_dam; }
        set { mortar_dam = value; }
    }

    public FragGrenadeAbility fragGrenade
    {
        get { return fragren; }
    }

    public MortarStrikeAbility mortarStrike
    {
        get { return mort; }
    }

}

