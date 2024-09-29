using System;

namespace ProBuilder2.Common
{
	[Serializable]
	public struct pb_Edge
	{
		public pb_Edge(pb_Edge edge) : this()
		{
		}

		public int x;
		public int y;
	}
}
