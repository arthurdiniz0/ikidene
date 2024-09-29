using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class StartBehaviorTree : Action
	{
		public SharedGameObject behaviorGameObject;
		public SharedInt group;
		public SharedBool waitForCompletion;
		public SharedBool synchronizeVariables;
	}
}
