using UnityEngine;
using System;

namespace PixelCrushers.DialogueSystem.PlayMaker
{
	public class DialogueSystemEventsToPlayMaker : MonoBehaviour
	{
		[Serializable]
		public class EventData
		{
			public string responseSeparator;
		}

		public PlayMakerFSM[] FSMs;
		public EventData eventData;
		public bool debug;
	}
}
