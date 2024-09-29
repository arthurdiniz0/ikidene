using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class GetFieldValue : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString fieldName;
	}
}
