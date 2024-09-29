using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class SetFieldValue : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString fieldName;
	}
}
