using UtilityEngine;
using System.Collections;
using System.Diagnostics;

// define aoe aspects of ability
// create new folder in Ability System called Behaviors 
// create new C# script in Behaviors called AreaOfEffect.cs

public class AreaOfEffect: AbilityBehaviors {

   private const string abName = "Area of Effect";
   private const string abDesc = "An area of damage!";
   private const BehaviorStartTimes startTime = BehaviorStartTimes.End; //on impact
   //private const Sprite icon = Resources.Load();
   
   private float areaRadius;
   private float effectDuration;
   private Stopwatch durationTimer = new Stopwatch();
   private float baseEffectDamage;
   private bool isOccupied;
   private float damageTickDuration;

   public AreaOfEffect(float ar, float ed, float bd)
      : base(new BasicObjectInformation(abName, abDesc), startTime){
      areaRadius = ar;
	  effectDuration = ed;
	  baseEffectDamage = bd;
	  isOccupied = false;
   }

   //override behaviour
   public override void PerformBehavior(){
      StartCoroutine(AOE());
   }
   
   private IEnumerator AOE(){
      durationTimer.Start();
	  while(durationTimer.Elapsed.TotalSeconds <= effectDuration){
	     if(isOccupied){
		    //do damage
		 }
		 yield return new WaitforSeconds(damageTickDuration);
	  }
	  durationTimer.Stop();
	  durationTimer.Reset();
   }