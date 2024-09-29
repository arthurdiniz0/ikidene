using System;
using UnityEngine;

[Serializable]
public class PerfectLookAtData
{
	public Transform m_Bone;
	public float m_RotationLimit;
	public float m_RotateAroundUpVectorWeight;
	public FwdDirection m_ForwardAxis;
	public FwdDirection m_ParentBoneForwardAxis;
	public bool m_ResetToDefaultRotation;
	public PerfecLookAtLinkedBones[] m_LinkedBones;
}
