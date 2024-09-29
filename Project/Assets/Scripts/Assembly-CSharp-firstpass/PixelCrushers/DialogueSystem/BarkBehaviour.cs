using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class BarkBehaviour : PlayableBehaviour
	{
		public bool useConversation;
		public string conversation;
		public string text;
		public Transform listener;
	}
}
