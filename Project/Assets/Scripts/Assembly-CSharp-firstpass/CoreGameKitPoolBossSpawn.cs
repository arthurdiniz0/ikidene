using HutongGames.PlayMaker;
using DarkTonic.CoreGameKit;

public class CoreGameKitPoolBossSpawn : FsmStateAction
{
	public WaveSpecifics.SpawnOrigin prefabSource;
	public FsmGameObject prefabToSpawn;
	public WavePrefabPool prefabPoolByRef;
	public string prefabPoolByName;
	public LevelSettings.SpawnPositionMode spawnPositionMode;
	public FsmVector3 spawnLocation;
	public FsmGameObject otherObjectForPosition;
	public LevelSettings.RotationType rotationType;
	public FsmVector3 eulerRotation;
	public FsmGameObject parentGameObject;
	public FsmGameObject spawnedGameObject;
}
