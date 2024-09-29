using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedTransformList : Conditional
	{
		public SharedTransformList variable;
		public SharedTransformList compareTo;
	}
}
