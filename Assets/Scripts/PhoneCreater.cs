using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCreater : MonoBehaviour

{
    IphoneFactory ęphoneFactory = new IphoneFactory();

    private void Start()
    {
            Phone ęphone = ęphoneFactory.GetPhone("irem", "ceren", 100, 200);
            Debug.Log(ęphone);
            IphoneFactory androidFactory = new IphoneFactory();
            Phone android = androidFactory.GetPhone("zeren", "elen", 300, 500);
        Debug.Log(android);



    }
}
