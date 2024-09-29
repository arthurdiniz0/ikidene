using System;
using UnityEngine.UI;
using PixelCrushers;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUITypewriterEffect : AbstractTypewriterEffect
	{
		[Serializable]
		public class AutoScrollSettings
		{
			public bool autoScrollEnabled;
			public ScrollRect scrollRect;
			public UIScrollbarEnabler scrollbarEnabler;
			public Text sizerText;
		}

		public AutoScrollSettings autoScrollSettings;
		public UnityEvent onBegin;
		public UnityEvent onCharacter;
		public UnityEvent onEnd;
	}
}
