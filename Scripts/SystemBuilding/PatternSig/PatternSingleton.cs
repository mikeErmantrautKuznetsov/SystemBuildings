using System;
using UnityEngine;

public class PatternSingleton : MonoBehaviour
{
    private static readonly Lazy<PatternSingleton> instance = new Lazy<PatternSingleton>(() => new PatternSingleton());

    public bool buildBool = true;
    public bool buildFloor = true;
    public bool buildWall = true;
    public bool buildRoof = true;
    public bool isActivePanel = false;

    public static PatternSingleton Instance => instance.Value;
}
