using System;

public class LSSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(LSPoison);
	}
}
