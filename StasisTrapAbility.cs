using UtilityEngine;
using System.Collections;

// new ability 3 of recon class
// create new folder in Ability System called Abilities 
// create new C# script in Abilities called StasisTrapAbility.cs
// lays a mine that roots characters (1 phase) that get too close

public class StasisTrapAbility : Ability
{
    private const string aName = "Stasis Trap";
    private const string aDesc = "lays a mine that roots characters (1 phase) that get too close";
    //private const Sprite icon = Resources.Load();
    private int initial_cd;
    private int cd;
    private int coordx;
    private int coordy;
    private bool mine_hit;
    private int effect_duration;
    private BaseCharacterClass target;
    private int temp_move_speed;

    public StasisTrapAbility() : base(new BasicObjectInformation(aName, aDesc))
    {
        initial_cd = 0;
        cd = 4;
        mine_hit = false;
        effect_duration = 1;
    }

    public void activateTrap(int targetx, int targety)
    {
        if (coordx == targetx && coordy == targety)
        {
            temp_move_speed = target.MovementSpeed;
            target.MovementSpeed = 0;
        }
    }

    public void restoreValues()
    {
        target.MovementSpeed = temp_move_speed;
    }

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

    public int CoordinatesX
    {
        get { return coordx; }
        set { coordx = value; }
    }

    public int CoordinatesY
    {
        get { return coordy; }
        set { coordy = value; }
    }

    public bool Target_Hit
    {
        get { return mine_hit; }
        set { mine_hit = value; }
    }

    public int EffectTime
    {
        get { return effect_duration; }
        set { effect_duration = value; }
    }

    public int OriginalSpeedValue
    {
        get { return temp_move_speed; }
        set { temp_move_speed = value; }
    }

}