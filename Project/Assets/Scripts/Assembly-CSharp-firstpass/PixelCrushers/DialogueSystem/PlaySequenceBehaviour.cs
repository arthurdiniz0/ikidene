using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class PlaySequenceBehaviour : PlayableBehaviour
	{
		[TextAreaAttribute]
		public string sequence;
		public Transform listener;
	}
}
