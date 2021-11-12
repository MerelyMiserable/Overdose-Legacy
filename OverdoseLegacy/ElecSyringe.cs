using System;

public class ElecSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(ElecPoison);
	}
}
