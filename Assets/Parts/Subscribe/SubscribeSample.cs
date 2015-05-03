using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class SubscribeSample : Base
{

	// Use this for initialization
	void Start () {

        //Returnで(0,1)という値をSubscribe内に流し込んでる
        Observable.Return(new Vector2(0, 1))
            .Subscribe(v => gameObject.transform.position = v);

        //UpdateAsObservableでUpdateのたびに値流しこんでる
        this.UpdateAsObservable().Subscribe(_ => Move(0.01f, 0));
	}
}
