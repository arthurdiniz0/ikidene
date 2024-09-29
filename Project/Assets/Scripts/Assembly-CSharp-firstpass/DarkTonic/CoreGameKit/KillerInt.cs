using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class KillerInt : KillerVariable
	{
		public KillerInt(int startingValue)
		{
		}

		public int selfValue;
		public int minimum;
		public int maximum;
	}
}
