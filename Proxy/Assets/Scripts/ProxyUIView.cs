using UnityEngine;
using System.Collections;
using System;
public class ProxyUIView
{
    public static void Proxy(Transform transform, Color imageColor, Action callback, string txt = "", string btnTxt = "")
    {
        UIView v = new UIView();
        v.Init(transform, callback, imageColor, txt, btnTxt);
    }
}
