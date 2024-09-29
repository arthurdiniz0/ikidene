using UnityEngine.EventSystems;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class EventTriggerActionBase : ComponentAction<EventTrigger>
	{
		public FsmOwnerDefault gameObject;
		public FsmEventTarget eventTarget;
	}
}
