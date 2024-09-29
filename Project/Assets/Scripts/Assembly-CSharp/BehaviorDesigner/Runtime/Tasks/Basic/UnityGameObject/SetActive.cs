using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityGameObject
{
	public class SetActive : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool active;
	}
}
