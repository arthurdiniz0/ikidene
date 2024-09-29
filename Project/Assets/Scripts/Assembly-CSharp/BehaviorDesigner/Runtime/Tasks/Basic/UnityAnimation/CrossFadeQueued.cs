using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class CrossFadeQueued : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
		public float fadeLength;
		public QueueMode queue;
		public PlayMode playMode;
	}
}
