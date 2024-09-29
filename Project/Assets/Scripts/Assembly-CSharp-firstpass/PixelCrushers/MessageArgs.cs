using System;

namespace PixelCrushers
{
	[Serializable]
	public struct MessageArgs
	{
		public MessageArgs(object sender, string message, string parameter, object[] values) : this()
		{
		}

		public string message;
		public string parameter;
	}
}
