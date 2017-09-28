using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Role {
    public string name;
    public Affiliation affiliation;
    [Tooltip("-1 value means infinite uses")]
    public int usesRemaining;
}