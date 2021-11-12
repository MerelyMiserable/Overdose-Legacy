using System;
using System.Collections;
using UnityEngine;
	class antiWincePoison : PoisonSpreadBehaviour
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
		bool spaz = false;
		PlayerPrefs.SetInt("onoff", spaz ? 1 : 0);
		PlayerPrefs.Save();
	}

	public antiWincePoison()
	{
	}
	public void Update()
	{
	}
	bool spaz = PlayerPrefs.GetInt("onoff") == 1 ? true : false;
}
