using UtilityEngine;
using System.Collections;
using System.Collections.Generic

// define characteristics of ability
// create new folder in scripts called Ability System
// create new C# script in Ability System called Ability.cs

public class Ability {

   private BasicObjectInformation objectInfo;
   private List<AbilityBehaviors> behaviors;
   private bool target;
   private bool selfcast;
   private int cd;      //phases
   private GameObject particleEffect;
   private AbilityType type;
   
   public enum AbilityType {
      Passive,
      Active
   }
   
   public Ability(BasicObjectInformation aBasicInfo) {
      objectInfo = aBasicInfo;
	  behaviors = new List<global::AbilityBehaviors>();
	  //cd = acd;
	  target = false;
	  selfcast = false;
	  //particleEffect = aparticleE;
   }
   
   public Ability(BasicObjectInformation aBasicInfo, List<AbilityBehaviors> abehaviors, bool atarget, int acd, GameObject aparticleE) {
      objectInfo = aBasicInfo;
      behaviors = abehaviors;
	  cd = acd;
	  target = false;
	  selfcast = false;
	  particleEffect = aparticleE;
   }
   
   public BasicObjectInformation AbilityInfo {
      get { return objectInfo; }
   }
   
   public int AbilityCd {
      get { return cd; }
   }
   
   public List<AbilityBehaviors> AbilityBehaviors {
      get { return behaviors; }
   }
   
   public void UseAbility {

   }
   
}