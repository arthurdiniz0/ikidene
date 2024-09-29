using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedTransform : Conditional
	{
		public SharedTransform variable;
		public SharedTransform compareTo;
	}
}
