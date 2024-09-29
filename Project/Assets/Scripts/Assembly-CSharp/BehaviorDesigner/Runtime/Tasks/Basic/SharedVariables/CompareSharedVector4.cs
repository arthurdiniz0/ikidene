using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedVector4 : Conditional
	{
		public SharedVector4 variable;
		public SharedVector4 compareTo;
	}
}
