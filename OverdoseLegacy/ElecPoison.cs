using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public class ElecPoison : PoisonSpreadBehaviour
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x00017CC9 File Offset: 0x00015EC9
	public override float SpreadSpeed
	{
		get
		{
			return 1.4f;
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
		physicalBehaviour.Charge = 50;
	}
}
