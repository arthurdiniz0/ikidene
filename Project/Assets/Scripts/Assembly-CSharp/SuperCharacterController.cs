using UnityEngine;

public class SuperCharacterController : MonoBehaviour
{
	[SerializeField]
	private Vector3 debugMove;
	[SerializeField]
	private QueryTriggerInteraction triggerInteraction;
	[SerializeField]
	private bool fixedTimeStep;
	[SerializeField]
	private int fixedUpdatesPerSecond;
	[SerializeField]
	private bool clampToMovingGround;
	[SerializeField]
	private bool debugSpheres;
	[SerializeField]
	private bool debugGrounding;
	[SerializeField]
	private bool debugPushbackMesssages;
	[SerializeField]
	private CollisionSphere[] spheres;
	public LayerMask Walkable;
	[SerializeField]
	private Collider ownCollider;
	[SerializeField]
	public float radius;
}
