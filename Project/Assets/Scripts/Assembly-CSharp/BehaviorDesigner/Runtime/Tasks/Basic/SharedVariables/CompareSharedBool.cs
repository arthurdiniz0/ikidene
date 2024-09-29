using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedBool : Conditional
	{
		public SharedBool variable;
		public SharedBool compareTo;
	}
}
