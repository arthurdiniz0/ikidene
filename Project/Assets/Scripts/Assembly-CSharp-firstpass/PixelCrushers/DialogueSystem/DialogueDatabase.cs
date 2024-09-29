using UnityEngine;
using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueDatabase : ScriptableObject
	{
		[Serializable]
		public class SyncInfo
		{
			public bool syncActors;
			public bool syncItems;
			public bool syncLocations;
			public bool syncVariables;
			public DialogueDatabase syncActorsDatabase;
			public DialogueDatabase syncItemsDatabase;
			public DialogueDatabase syncLocationsDatabase;
			public DialogueDatabase syncVariablesDatabase;
		}

		public string version;
		public string author;
		public string description;
		public string globalUserScript;
		public EmphasisSetting[] emphasisSettings;
		public List<Actor> actors;
		public List<Item> items;
		public List<Location> locations;
		public List<Variable> variables;
		public List<Conversation> conversations;
		public SyncInfo syncInfo;
	}
}
