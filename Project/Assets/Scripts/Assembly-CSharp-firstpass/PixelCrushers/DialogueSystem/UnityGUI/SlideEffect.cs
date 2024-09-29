namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class SlideEffect : GUIEffect
	{
		public enum SlideDirection
		{
			FromBottom = 0,
			FromTop = 1,
			FromLeft = 2,
			FromRight = 3,
		}

		public SlideDirection direction;
		public float duration;
	}
}
