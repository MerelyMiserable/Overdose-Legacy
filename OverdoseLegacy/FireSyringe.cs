using System;

public class FireSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(FirePoison);
	}
}
