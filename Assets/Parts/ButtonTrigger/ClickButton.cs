using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniRx;

public class ClickButton : Base {

    public Button Button;
	// Use this for initialization
	void Start () {
        gameObject.transform.position = new Vector2(0, 1f);
        //一回だけ右に移動
        Button.onClick.AsObservable().First()
            .Subscribe(l => Move(1f, 0));


	}
}
