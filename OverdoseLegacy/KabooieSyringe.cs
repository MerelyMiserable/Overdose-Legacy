using System;

public class KabooieSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(KabooiePoison);
	}
}
