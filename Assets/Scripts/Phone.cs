using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone
{
    public string model;
    public string battery;
    public int width;
    public int height;

    public override string ToString()
    {

        return model + battery + width + height;

    }

}
