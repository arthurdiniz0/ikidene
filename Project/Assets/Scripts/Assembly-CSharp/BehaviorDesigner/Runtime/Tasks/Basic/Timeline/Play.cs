using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine.Playables;

namespace BehaviorDesigner.Runtime.Tasks.Basic.Timeline
{
	public class Play : Action
	{
		public SharedGameObject targetGameObject;
		public PlayableAsset playableAsset;
		public SharedBool stopWhenComplete;
	}
}
