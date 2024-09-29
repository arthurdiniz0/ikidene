using UnityEngine;
using System;
using System.Collections.Generic;

namespace BehaviorDesigner.Runtime
{
	public class VariableSynchronizer : MonoBehaviour
	{
		[Serializable]
		public class SynchronizedVariable
		{
			public SynchronizedVariable(VariableSynchronizer.SynchronizationType synchronizationType, bool setVariable, Behavior behavior, string variableName, bool global, Component targetComponent, string targetName, bool targetGlobal)
			{
			}

			public VariableSynchronizer.SynchronizationType synchronizationType;
			public bool setVariable;
			public Behavior behavior;
			public string variableName;
			public bool global;
			public Component targetComponent;
			public string targetName;
			public bool targetGlobal;
			public Animator animator;
			public VariableSynchronizer.AnimatorParameterType animatorParameterType;
			public int targetID;
		}

		public enum SynchronizationType
		{
			BehaviorDesigner = 0,
			Property = 1,
			Animator = 2,
			PlayMaker = 3,
			uFrame = 4,
		}

		public enum AnimatorParameterType
		{
			Bool = 0,
			Float = 1,
			Integer = 2,
		}

		[SerializeField]
		private UpdateIntervalType updateInterval;
		[SerializeField]
		private float updateIntervalSeconds;
		[SerializeField]
		private List<VariableSynchronizer.SynchronizedVariable> synchronizedVariables;
	}
}
