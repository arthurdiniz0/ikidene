using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Template
	{
		public bool treatItemsAsQuests;
		public List<Field> actorFields;
		public List<Field> itemFields;
		public List<Field> questFields;
		public List<Field> locationFields;
		public List<Field> variableFields;
		public List<Field> conversationFields;
		public List<Field> dialogueEntryFields;
		public List<string> actorPrimaryFieldTitles;
		public List<string> itemPrimaryFieldTitles;
		public List<string> questPrimaryFieldTitles;
		public List<string> locationPrimaryFieldTitles;
		public List<string> variablePrimaryFieldTitles;
		public List<string> conversationPrimaryFieldTitles;
		public List<string> dialogueEntryPrimaryFieldTitles;
		public Color npcLineColor;
		public Color pcLineColor;
		public Color repeatLineColor;
	}
}
