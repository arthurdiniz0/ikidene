using System;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class ShowAlertBehaviour : PlayableBehaviour
	{
		public string message;
		public bool useTextLengthForDuration;
	}
}
