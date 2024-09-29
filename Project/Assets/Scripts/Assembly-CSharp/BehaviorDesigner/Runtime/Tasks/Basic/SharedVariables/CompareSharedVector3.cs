using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.SharedVariables
{
	public class CompareSharedVector3 : Conditional
	{
		public SharedVector3 variable;
		public SharedVector3 compareTo;
	}
}
