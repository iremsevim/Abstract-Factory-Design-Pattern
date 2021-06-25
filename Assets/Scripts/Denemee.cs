using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="irem",menuName ="Deniz")]
public class Denemee : ScriptableObject
{
    public string battery;
    public int width;

    public bool isWalk;
    public virtual void  GetElements(string battery,int width)
    {
        this.battery = battery;
        this.width = width;
    }

    
}
