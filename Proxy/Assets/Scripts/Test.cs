using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void OnGUI()
    {
        if(GUI.Button(new Rect(100, 100, 120,50), "代理者"))
        {
            ProxyUIView.Proxy(this.transform, Color.green, Callback, "代理者", "代理者按钮");
        }
    }
     
    private void Callback()
    {
        print("代理成功");
    }
}
