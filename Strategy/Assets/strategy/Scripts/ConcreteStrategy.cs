using UnityEngine;
using System.Collections;

public class ConcreteStrategyA : Strategy
{
    public override void ConcreteStrategy()
    {
        base.ConcreteStrategy();
        mText.text = "这个是策略A";
        mBtnText.text = "策略A";
    }

    public override void OnClick()
    {
        Debug.Log("ButtonA");
    }
}

public class ConcreteStrategyB : Strategy
{
    public override void ConcreteStrategy()
    {
        base.ConcreteStrategy();
        mText.text = "这个是策略B";
        mBtnText.text = "策略B";
        mBtnText.color = Color.red;
    }

    public override void OnClick()
    {
        Debug.Log("ButtonB");
    }
}

public class ConcreteStrategyC : Strategy
{
    public override void ConcreteStrategy()
    {
        base.ConcreteStrategy();
        mText.text = "这个是策略C";
        mBtnText.text = "策略C";
        mBtnText.color = Color.green;
    }

    public override void OnClick()
    {
        Debug.Log("ButtonC");
    }
}
