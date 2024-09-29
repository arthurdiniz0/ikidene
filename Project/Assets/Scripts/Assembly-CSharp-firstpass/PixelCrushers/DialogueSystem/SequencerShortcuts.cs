using UnityEngine;
using System;

namespace PixelCrushers.DialogueSystem
{
	public class SequencerShortcuts : MonoBehaviour
	{
		[Serializable]
		public class Shortcut
		{
			public string shortcut;
			[TextAreaAttribute]
			public string value;
		}

		public Shortcut[] shortcuts;
	}
}
