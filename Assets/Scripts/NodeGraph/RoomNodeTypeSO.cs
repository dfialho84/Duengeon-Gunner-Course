using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{

    public string roomNodeTypeName;

    #region 
    [Header("Only flat the RoomNodeType that should visible in the editor")]
    #endregion
    public bool displayInNodeGraphEditor = true;
    
    #region 
    [Header("One Type should be a Corridor")]
    #endregion
    public bool isCorridor;

    #region 
    [Header("One Type should be a CorridorNS")]
    #endregion
    public bool isCorridorNS;
    
    #region 
    [Header("One Type should be a CorridorEW")]
    #endregion
    public bool isCorddidorEW;
    
    #region 
    [Header("One Type should be as entrance")]
    #endregion
    public bool isEntrance;
    
    #region 
    [Header("One Type should be a Boss Room")]
    #endregion
    public bool isBossRoom;

    #region 
    [Header("One Type should be a None (Unassigned)")]
    #endregion
    public bool isNone;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif
    #endregion
}
