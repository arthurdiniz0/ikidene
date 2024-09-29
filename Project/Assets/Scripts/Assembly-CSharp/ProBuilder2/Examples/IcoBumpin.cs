using UnityEngine;

namespace ProBuilder2.Examples
{
	public class IcoBumpin : MonoBehaviour
	{
		public float icoRadius;
		public int icoSubdivisions;
		public float startingExtrusion;
		public Material material;
		public float extrusion;
		public int fftBounds;
		public float verticalBounce;
		public AnimationCurve frequencyCurve;
		public LineRenderer waveform;
		public float waveformHeight;
		public float waveformRadius;
		public float waveformSpeed;
		public bool rotateWaveformRing;
		public bool bounceWaveform;
		public GameObject missingClipWarning;
	}
}
