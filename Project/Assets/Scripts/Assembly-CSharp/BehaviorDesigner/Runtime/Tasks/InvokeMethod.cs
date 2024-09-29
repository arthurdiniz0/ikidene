using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class InvokeMethod : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString methodName;
	}
}
