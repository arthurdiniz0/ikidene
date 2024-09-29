using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class DialogueEntry
	{
		public int id;
		public List<Field> fields;
		public int conversationID;
		public bool isRoot;
		public bool isGroup;
		public string nodeColor;
		public bool delaySimStatus;
		public string falseConditionAction;
		public ConditionPriority conditionPriority;
		public List<Link> outgoingLinks;
		public string conditionsString;
		public string userScript;
		public UnityEvent onExecute;
		public Rect canvasRect;
	}
}
