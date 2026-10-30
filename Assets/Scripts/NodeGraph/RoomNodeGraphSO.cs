using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeGraph", menuName = "Scriptable Objects/Dungeon/Room Node Graph")]
public class NewScriptableObjectScript : ScriptableObject
{
    [HideInInspector]
    public RoomNodeTypeListSO roomNodeTypeList;

    [HideInInspector]
    public List<RoomNodeSO> roomNodeList = new List<RoomNodeSO>();

    [HideInInspector]
    [SerializeField]
    public Dictionary<string, RoomNodeSO> roomNodeDictionary = new Dictionary<string, RoomNodeSO>();
}
