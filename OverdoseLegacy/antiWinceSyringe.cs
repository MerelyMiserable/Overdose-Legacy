using System;

public class antiWinceSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(antiWincePoison);
	}
}
