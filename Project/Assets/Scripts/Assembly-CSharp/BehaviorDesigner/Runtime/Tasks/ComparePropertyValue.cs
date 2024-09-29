using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class ComparePropertyValue : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString propertyName;
	}
}
