using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class StopBehaviorTree : Action
	{
		public SharedGameObject behaviorGameObject;
		public SharedInt group;
		public SharedBool pauseBehavior;
	}
}
