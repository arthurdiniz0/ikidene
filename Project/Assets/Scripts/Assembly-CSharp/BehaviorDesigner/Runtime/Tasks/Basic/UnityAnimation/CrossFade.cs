using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class CrossFade : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
		public float fadeLength;
		public PlayMode playMode;
	}
}
