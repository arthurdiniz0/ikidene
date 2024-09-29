using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Conversation : Asset
	{
		public ConversationOverrideDisplaySettings overrideSettings;
		public string nodeColor;
		public List<DialogueEntry> dialogueEntries;
		public Vector2 canvasScrollPosition;
		public float canvasZoom;
	}
}
