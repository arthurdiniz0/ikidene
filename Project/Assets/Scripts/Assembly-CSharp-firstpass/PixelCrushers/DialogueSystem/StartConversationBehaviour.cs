using System;
using UnityEngine.Playables;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StartConversationBehaviour : PlayableBehaviour
	{
		public Transform conversant;
		public string conversation;
		public bool jumpToSpecificEntry;
		public int entryID;
	}
}
