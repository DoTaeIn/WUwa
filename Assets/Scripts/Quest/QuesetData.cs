using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuesetData
{
    public int questId; // Quest Identifier
    public string questName;
    public string questDescription;
    public List<NpcData> associatedNpcs; // NPC associated with this quest
    public List<InteractableObjs> associatedInteractables; // Interactable Objects associated with this quest
    public int max_order; // Maximum number of Quest conversation order
    public int current_order; // Current number of Quest conversation order
    
    
    
    public QuesetData(int _questId, string _questName, string _questDescription,List<NpcData> _associatedNpcs, List<InteractableObjs> _associatedInteractables,
        int _max_order, int _current_order)
    {
        questId = _questId;
        questName = _questName;
        questDescription = _questDescription;
        associatedNpcs = _associatedNpcs;
        associatedInteractables = _associatedInteractables;
        max_order = _max_order;
        current_order = _current_order;
    }
    
}
