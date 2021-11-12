using System;

public class BetterSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(BetterPoison);
	}
}
