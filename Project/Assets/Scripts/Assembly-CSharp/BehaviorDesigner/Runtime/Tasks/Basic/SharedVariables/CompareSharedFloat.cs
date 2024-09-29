using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedFloat : Conditional
	{
		public SharedFloat variable;
		public SharedFloat compareTo;
	}
}
