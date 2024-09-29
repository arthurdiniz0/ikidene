using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class KillerFloat : KillerVariable
	{
		public KillerFloat(float startingValue)
		{
		}

		public float selfValue;
		public float minimum;
		public float maximum;
	}
}
