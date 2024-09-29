using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class GetColor : Action
	{
		public SharedGameObject targetGameObject;
		public SharedColor storeValue;
	}
}
