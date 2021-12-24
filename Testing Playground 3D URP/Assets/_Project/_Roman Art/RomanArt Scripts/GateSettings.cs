using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSettings : MonoBehaviour
{
    [SerializeField, Tooltip("This gates name/label")] public string GateName;
    [SerializeField, Tooltip("The name of the scene to load")] public string toScene;
    [SerializeField, Tooltip("The name of the gate to move to")] public string toGate;

    private void Start()
    {
        if (GateName == null) Debug.LogError(name + "GateName can not be null");
        if (toScene == null) Debug.LogError(name + "toScene can not be null");
        if (toGate == null) Debug.LogError(name + "toGate can not be null");
    }
}
