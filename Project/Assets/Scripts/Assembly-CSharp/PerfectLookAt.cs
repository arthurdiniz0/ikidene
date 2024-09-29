using UnityEngine;

public class PerfectLookAt : MonoBehaviour
{
	public GameObject m_TargetObject;
	public Vector3 m_UpVector;
	public float m_Weight;
	public float m_LookAtBlendSpeed;
	public float m_LegStabilizerMinDistanceToStartSolving;
	public byte LegStabilizerMaxIterations;
	public bool m_DrawDebugLookAtLines;
	public PerfectLookAtData[] m_LookAtBones;
	public PerfectLookAtLegStabilizer[] m_legStabilizers;
}
