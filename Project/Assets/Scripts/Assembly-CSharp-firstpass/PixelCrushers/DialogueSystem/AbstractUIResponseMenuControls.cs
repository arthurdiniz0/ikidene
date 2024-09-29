using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class AbstractUIResponseMenuControls : AbstractUIControls
	{
		public ResponseButtonAlignment buttonAlignment;
		public bool showUnusedButtons;
	}
}
