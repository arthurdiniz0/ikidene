using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityString
{
	public class GetLength : Action
	{
		public SharedString targetString;
		public SharedInt storeResult;
	}
}
