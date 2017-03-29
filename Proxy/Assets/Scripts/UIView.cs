using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UIView  {
    private Text mText;
   // private Button mButton;
    private Text mBtnText;
    private Image mImage;

    private Action Callback;

    public UIView() { }


    public void Init(Transform transform, Action callback, Color imageColor, string txt = "", string btnTxt = "")
    {
        InitUI(transform);
        SetText(txt);
        SetBtnText(btnTxt);
        SetImage(imageColor);
        Callback = callback;
    }

    private void InitUI(Transform transform)
    {
        mText = transform.Find("Text").GetComponent<Text>();
        Button mButton = transform.Find("Button").GetComponent<Button>();
        mBtnText = transform.Find("Button/Text").GetComponent<Text>();
        mImage = transform.Find("Image").GetComponent<Image>();

        mButton.onClick.AddListener(onClick);
    }

    private void onClick()
    {
        if(Callback != null)
        {
            Callback();
        }
    }

    private void SetText(string txt)
    {
        mText.text = txt;
    }

    private void SetBtnText(string txt)
    {
        mBtnText.text = txt;
    }

    private void SetImage(Color color)
    {
        mImage.color = color;
    }
}
