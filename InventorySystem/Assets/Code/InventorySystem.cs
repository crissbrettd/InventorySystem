﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Code.ScriptableObjects;

public class InventorySystem : MonoBehaviour
{
    private int _numInventorySpaces;
    [SerializeField] public int NumInventorySpaces { get => _numInventorySpaces; set => _numInventorySpaces = value; }

    public List<Item> InventoryItemList;

}
