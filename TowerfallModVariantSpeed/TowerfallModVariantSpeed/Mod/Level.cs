using System;
using System.Xml;
using Monocle;
using Patcher;
using TowerFall;

namespace TowerfallModVariantSpeed {
  [Patch]
  public class ModLevel : Level {
    
Action originalUpdate;

    public ModLevel(Session session, XmlElement xml) : base(session, xml) {
      var ptr = typeof(Level).GetMethod("$original_Update").MethodHandle.GetFunctionPointer();
      originalUpdate = (Action)Activator.CreateInstance(typeof(Action), this, ptr);
    }

		public override void Update() {

      originalUpdate();

      if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_1)
      {
        Engine.TimeRate = 1.1f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_2)
      {
        Engine.TimeRate = 1.2f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_3)
      {
        Engine.TimeRate = 1.3f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_4)
      {
        Engine.TimeRate = 1.4f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_5)
      {
        Engine.TimeRate = 1.5f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_6)
      {
        Engine.TimeRate = 1.6f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_7)
      {
        Engine.TimeRate = 1.7f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_8)
      {
        Engine.TimeRate = 1.8f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX1_9)
      {
        Engine.TimeRate = 1.9f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX2)
      {
        Engine.TimeRate = 2f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX2_5)
      {
        Engine.TimeRate = 2.5f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX3)
      {
        Engine.TimeRate = 3f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX3_5)
      {
        Engine.TimeRate = 3.5f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX4)
      {
        Engine.TimeRate = 4f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX4_5)
      {
        Engine.TimeRate = 4.5f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX5)
      {
        Engine.TimeRate = 5f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX6)
      {
        Engine.TimeRate = 6f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX7)
      {
        Engine.TimeRate = 7f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX8)
      {
        Engine.TimeRate = 8f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX9)
      {
        Engine.TimeRate = 9f;
      }
      else if ((bool)((MyMatchVariants)this.Session.MatchSettings.Variants).SpeedX10)
      {
        Engine.TimeRate = 10f;
      }
    }
  }
}
