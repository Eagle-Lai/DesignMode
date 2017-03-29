using UnityEngine;
using System.Collections;
using UnityEngine.UI ;
using System;

public class Strategy 
{
  public Text mText;
  public Button mButton;
  public Text mBtnText;
   public Strategy strategy;

   public Strategy() { }

    public Strategy( Strategy strategy)
   {
       this.strategy = strategy;
   }

  public void Init(Transform transform)
    {
        mText = transform.Find("Text").GetComponent<Text>();
        mButton = transform.Find("Button").GetComponent<Button>();
        mBtnText = mButton.transform.Find("Text").GetComponent<Text>();
        
        mButton.onClick.AddListener(OnClick);
    }

    public virtual void OnClick()
    {

    }
    public virtual void ConcreteStrategy() 
    {
        OnClick();
    }
}
