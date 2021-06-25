using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneCreater : MonoBehaviour

{
    IphoneFactory �phoneFactory = new IphoneFactory();

    private void Start()
    {
            Phone �phone = �phoneFactory.GetPhone("irem", "ceren", 100, 200);
            Debug.Log(�phone);
            IphoneFactory androidFactory = new IphoneFactory();
            Phone android = androidFactory.GetPhone("zeren", "elen", 300, 500);
        Debug.Log(android);



    }
}
