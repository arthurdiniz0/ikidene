using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class PlaySequenceClip : PlayableAsset
	{
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		public PlaySequenceBehaviour template;
		public ExposedReference<Transform> listener;
	}
}
