using UnityEngine;

namespace PixelCrushers
{
	public class HelpBoxAttribute : PropertyAttribute
	{
		public HelpBoxAttribute(string text, HelpBoxMessageType messageType)
		{
		}

		public string text;
		public HelpBoxMessageType messageType;
	}
}
