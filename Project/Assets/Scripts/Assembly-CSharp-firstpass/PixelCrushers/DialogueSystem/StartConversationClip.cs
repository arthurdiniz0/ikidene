using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StartConversationClip : PlayableAsset
	{
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		public StartConversationBehaviour template;
		public ExposedReference<Transform> conversant;
	}
}
