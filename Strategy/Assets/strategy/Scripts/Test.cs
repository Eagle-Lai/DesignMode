using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {


    void OnGUI()
    {
        if(GUI.Button(new Rect(100,100,200,100),"策略A"))
        {
            Context c1 = new Context(new ConcreteStrategyA(),this.transform);
            c1.ConcreteStrategy();
        }

        if (GUI.Button(new Rect(100, 200, 200, 100), "策略B"))
        {
            Context c1 = new Context(new ConcreteStrategyB(), this.transform);
            c1.ConcreteStrategy();
        }

        if (GUI.Button(new Rect(100, 300, 200, 100), "策略C"))
        {
            Context c1 = new Context(new ConcreteStrategyC(), this.transform);
            c1.ConcreteStrategy();
        }
    }
}
