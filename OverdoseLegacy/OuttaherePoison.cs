using UnityEngine;
using System;
	class OuttaherePoison : PoisonSpreadBehaviour
	{
		public override void Start()
		{
			this.Limb.PhysicalBehaviour.rigidbody.gravityScale = -1f;
		}

		public OuttaherePoison()
		{
		}
	}
