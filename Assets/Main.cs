using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 主要用来串联一下两个类 实现DEMO功能
/// Author : YangDan
/// Site : blog.gamerisker.com
/// </summary>
public class Main : MonoBehaviour
{
    public SymbolInput input;

    public SymbolLabel label;

    public List<UISprite> list = new List<UISprite>();

	// Use this for initialization
	void Start ()
    {
        foreach (UISprite item in list)
        {
            UIEventListener.Get(item.gameObject).onClick = OnClick;
        }
	}

    private void OnClick(GameObject go)
    {
		string name = "#"+go.name.Substring (1, 2);
        input.value += name;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            label.text = input.value;
            input.value = "";
        }
	}

}
