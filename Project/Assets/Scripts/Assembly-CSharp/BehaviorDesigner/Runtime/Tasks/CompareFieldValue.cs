using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks
{
	public class CompareFieldValue : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString componentName;
		public SharedString fieldName;
	}
}
