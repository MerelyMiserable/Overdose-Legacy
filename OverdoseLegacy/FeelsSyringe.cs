using System;

public class FeelsSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(FeelsPoison);
	}
}
