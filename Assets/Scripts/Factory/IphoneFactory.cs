using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IphoneFactory : PhoneFactory
{
    public Phone GetPhone(string model, string battery, int width, int height)
    {
        return new Iphone(model, battery, width, height); 
    }
}
