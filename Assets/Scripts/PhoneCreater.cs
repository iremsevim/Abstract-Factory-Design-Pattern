using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCreater : MonoBehaviour

{
    IphoneFactory ýphoneFactory = new IphoneFactory();

    private void Start()
    {
            Phone ýphone = ýphoneFactory.GetPhone("irem", "ceren", 100, 200);
            Debug.Log(ýphone);
            IphoneFactory androidFactory = new IphoneFactory();
            Phone android = androidFactory.GetPhone("zeren", "elen", 300, 500);
        Debug.Log(android);



    }
}
