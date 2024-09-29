using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ActorPopupAttribute : PropertyAttribute
	{
		public ActorPopupAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
