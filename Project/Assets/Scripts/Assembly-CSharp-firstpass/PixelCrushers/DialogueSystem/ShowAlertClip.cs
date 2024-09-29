using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class ShowAlertClip : PlayableAsset
	{
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		public ShowAlertBehaviour template;
	}
}
