using UnityEngine.Playables;
using UnityEngine.Timeline;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class TimelineTrigger : DialogueEventStarter
	{
		public DialogueTriggerEvent trigger;
		public PlayableDirector playableDirector;
		public TimelineAsset timelineAsset;
		public Condition condition;
		public List<GameObject> bindings;
	}
}
