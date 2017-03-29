using UnityEngine;
using System.Collections;

public class Context
{
    public Strategy strategy;

    public Context(Strategy strategy,Transform transform)
    {
        this.strategy = strategy;
        this.strategy.Init(transform);
    }

    public void ConcreteStrategy()
    {
        strategy.ConcreteStrategy();
    }
}
