using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class FeelsPoison : PoisonSpreadBehaviour
{
	public override float SpreadSpeed
	{
		get
		{
			return 1.4f;
		}
	}

	public override void Start()
	{
			this.Limb.CirculationBehaviour.IsPump = this.Limb.CirculationBehaviour.WasInitiallyPumping;
			this.Limb.CirculationBehaviour.BloodAmount = 1f;
			this.Limb.CirculationBehaviour.BloodFlow = 1f;
			this.Limb.BreakingThreshold *= 250000f;
			this.Limb.BaseStrength *= 1.5f;
			this.Limb.Health = this.Limb.InitialHealth * 500000f;
			this.Limb.RegenerationSpeed += 999999f;
			this.Limb.Vitality *= 0.05f;
			this.Limb.ImpactPainMultiplier *= 0f;
			this.Limb.ShotDamageMultiplier *= 0f;
			if (this.Limb.IsLethalToBreak)
			{
				Limb.IsLethalToBreak = false;
			}
	}

	public void Update()
	{
		this.Limb.Health = this.Limb.InitialHealth * 500000f;
		this.Limb.CirculationBehaviour.BloodAmount = 1f;
		this.Limb.CirculationBehaviour.BloodFlow = 1f;
		this.Limb.Person.Consciousness = 1f;
	}

	public FeelsPoison()
	{
	}
}
