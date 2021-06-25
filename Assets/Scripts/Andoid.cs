using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andoid : Phone
{
    public Andoid(string _model, string _battery, int _width, int _height)
    {
        model = _model;
        battery = _battery;
        width = _width;
        height = _height;
    }
}
