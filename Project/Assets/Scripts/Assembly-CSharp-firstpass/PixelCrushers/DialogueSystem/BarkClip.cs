using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class BarkClip : PlayableAsset
	{
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		public BarkBehaviour template;
		public ExposedReference<Transform> listener;
	}
}
