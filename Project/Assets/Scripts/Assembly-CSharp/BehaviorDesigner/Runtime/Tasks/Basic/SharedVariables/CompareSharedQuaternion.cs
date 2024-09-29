using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedQuaternion : Conditional
	{
		public SharedQuaternion variable;
		public SharedQuaternion compareTo;
	}
}
