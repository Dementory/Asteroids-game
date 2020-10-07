using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Borders {
    public float upBorder, downBorder, leftBorder, rightBorder;
}

public class ToroidalUniverse : MonoBehaviour {
    public Borders borders;

    void Update () {
        var pos = transform.position;
        var x = transform.position.x;
        var y = transform.position.y;
        
        if (x > borders.rightBorder) {
            pos.x = borders.leftBorder;
            transform.position = pos;
        }
        if (x < borders.leftBorder) {
            pos.x = borders.rightBorder;
            transform.position = pos;
        }

        if (y > borders.upBorder) {
            pos.y = borders.downBorder;
            transform.position = pos;
        }
        if (y < borders.downBorder) {
            pos.y = borders.upBorder;
            transform.position = pos;
        }
    }
}