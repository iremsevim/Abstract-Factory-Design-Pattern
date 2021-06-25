using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndoidFactory : PhoneFactory
{
    public Phone GetPhone(string _model, string _battery, int _width, int _height)
    {
        return new Andoid(_model,_battery, _width, _height);
    }
}
