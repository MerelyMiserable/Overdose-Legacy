using System;

public class OuchSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(OuchPoison);
	}
}
