using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class GetPropertyValue : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString propertyName;
	}
}
