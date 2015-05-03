using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class SelectSample : Base {

	// Use this for initialization
	void Start () {
        //Returnで(0,1)という値をSubscribe内に流し込んでる
        Observable.Return(new Vector2(0, 1.5f)).Subscribe(v => gameObject.transform.position = v);

        //Selectを使って入力を加工してあげる
        this.UpdateAsObservable()
            .Select(_ => 2)
            .Subscribe(l => Move(0.01f * l, 0));
	}
	
}
