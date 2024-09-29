using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedObject : Conditional
	{
		public SharedObject variable;
		public SharedObject compareTo;
	}
}
