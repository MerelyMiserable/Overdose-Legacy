using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class BetterPoison : PoisonSpreadBehaviour
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x00017CC9 File Offset: 0x00015EC9
	public override float SpreadSpeed
	{
		get
		{
			return float.PositiveInfinity;
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00017CD0 File Offset: 0x00015ED0
	public override void Start()
	{
		this.WhatTheFuck();
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00017CD8 File Offset: 0x00015ED8
	private void WhatTheFuck()
	{
		PhysicalBehaviour physicalBehaviour = this.Limb.PhysicalBehaviour;
		this.Limb.HealBone();
		this.Limb.Health = 2147483647f;
		this.Limb.Numbness = -2147483647f;
		this.Limb.CirculationBehaviour.HealBleeding();
		this.Limb.CirculationBehaviour.IsPump = this.Limb.CirculationBehaviour.WasInitiallyPumping;
		this.Limb.CirculationBehaviour.BloodFlow = 2147483647f;
		this.Limb.CirculationBehaviour.BloodAmount = 2147483647f;
		this.Limb.BruiseCount = (ushort)0;
		this.Limb.CirculationBehaviour.GunshotWoundCount = (ushort)0;
		this.Limb.CirculationBehaviour.StabWoundCount = (ushort)0;
		this.Limb.Vitality *= 0.1f;
		this.Limb.RegenerationSpeed += 2147483647f;
		this.Limb.ImpactPainMultiplier *= 2147483647f;
		this.Limb.InitialHealth += 2147483647f;
		this.Limb.Health = this.Limb.InitialHealth;
		this.Limb.BreakingThreshold += 2147483647f;
		this.Limb.BaseStrength += 5;
		this.Limb.ShotDamageMultiplier = Math.Max(0f, this.Limb.ShotDamageMultiplier - 2147483647f);
		this.Limb.Wince (float.MaxValue);
		if (this.Limb.RoughClassification == LimbBehaviour.BodyPart.Head)
		{
			this.Limb.Person.Consciousness = 2147483647f;
			this.Limb.Person.ShockLevel = -2147483647f;
			this.Limb.Person.PainLevel = -2147483647f;
			this.Limb.Person.OxygenLevel = 2147483647f;
			this.Limb.Person.AdrenalineLevel = 2147483647f;

		}
	}
}
