using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Selection : MonoBehaviour {

    public string selection;
    [TextArea(3,10)]
    public string[] option;

}
