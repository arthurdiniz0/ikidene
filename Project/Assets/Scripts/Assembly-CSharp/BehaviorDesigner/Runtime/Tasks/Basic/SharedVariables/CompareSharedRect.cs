using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedRect : Conditional
	{
		public SharedRect variable;
		public SharedRect compareTo;
	}
}
