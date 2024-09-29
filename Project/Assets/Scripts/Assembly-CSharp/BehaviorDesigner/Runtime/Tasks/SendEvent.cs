using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class SendEvent : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString eventName;
		public SharedInt group;
	}
}
