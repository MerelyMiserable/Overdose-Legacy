using System;

public class OuttahereSyringe : OldSyringeBehaviour
{
	public override Type GetPoisonType()
	{
		return typeof(OuttaherePoison);
	}
}
