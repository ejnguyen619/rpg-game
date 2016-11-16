using UtilityEngine;
using System.Collections;

// define common characteristics of ability
// create new folder in scripts called Ability System
// create new C# script in Ability System called AbilityBehaviors.cs

public class AbilityBehaviors {

   private BasicObjectInformation objectInfo;
   private BehaviorStartTimes startTime; 

   public AbilityBehaviors(BasicObjectInformation basicInfo, BehaviorStartTimes sTime){
      objectInfo = basicInfo;
	  startTime = sTime;
   }
   
   public enum BehaviorStartTimes{
      Beginning,
	  Middle,
	  End
   }
   
   //override behaviour
   public virtual void PerformBehavior(){
      Debug.LogWarning("NEED TO ADD BEHAVIOR");
   }

   public BasicObjectInformation AbilityInfo {
      get { return objectInfo; }
   }

   public BehaviorStartTimes AbilityBehaviorsStartTime {
      get { return startTime; }
   }
}