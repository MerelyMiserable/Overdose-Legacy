using System;
using System.Collections;
using UnityEngine;
	class WincePoison : PoisonSpreadBehaviour
	{

		public override float SpreadSpeed
		{
			get
			{
				return 5f;
			}
		}

		public override void Start()
		{
			this.Update();
		}


	public WincePoison()
	{

	}
	public void Update()
	{
		this.Limb.Wince(22500000f);
        if (spaz == false)
        {
			this.Limb.Wince(0f);
		}
	}
	bool spaz = true;

	}
