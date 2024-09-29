using System;

namespace DarkTonic.CoreGameKit
{
	public class CoreScriptOrder : Attribute
	{
		public CoreScriptOrder(int order)
		{
		}

		public int Order;
	}
}
