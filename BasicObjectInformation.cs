using UtilityEngine;
using System.Collections;

// create new reference for Ability.cs
// create new folder in scripts called Stats
// create new C# script in Stats called BasicObjectInformation.cs

public class BasicObjectInformation {

   private string name;
   private string desc;
   private Sprite icon;
   
   public BasicObjectInformation(string oname) {
      name = oname;
   }

   public BasicObjectInformation(string oname, string odesc) {
      name = oname;
	  desc = odesc;
   }     

   public BasicObjectInformation(string oname, string odesc, Sprite oicon) {
      name = oname;
	  desc = odesc;
	  icon = oicon;
   }

   public string ObjectName {
      get { return name; }
   }   

   public string ObjectDesc {
      get { return desc; }
   }   
   
   public string ObjectIcon {
      get { return icon; }
   }   
   
}
