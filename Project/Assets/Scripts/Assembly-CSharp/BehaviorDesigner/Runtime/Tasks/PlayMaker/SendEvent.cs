using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.PlayMaker
{
	public class SendEvent : Action
	{
		public SharedGameObject playMakerGameObject;
		public SharedString FsmName;
		public SharedString eventName;
	}
}
