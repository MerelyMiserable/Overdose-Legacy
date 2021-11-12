using System;

public class WinceSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(WincePoison);
	}
}
