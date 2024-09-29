using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LuaOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class LuaAction : ActOnDialogueEvent.Action
		{
			[MultilineAttribute]
			public string luaCode;
		}

		public LuaAction[] onStart;
		public LuaAction[] onEnd;
		public bool debugLua;
	}
}
