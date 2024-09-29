using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityString
{
	public class GetSubstring : Action
	{
		public SharedString targetString;
		public SharedInt startIndex;
		public SharedInt length;
		public SharedString storeResult;
	}
}
