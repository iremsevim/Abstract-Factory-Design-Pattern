using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PhoneFactory 
{
    public Phone GetPhone(string _model, string _battery, int _width, int _height);
}
