using UnityEngine;
using System.Collections;
using UniRx;

public class SubscribeSample : Base
{

	// Use this for initialization
	void Start () {

        //Returnで(0,1)という値をSubscribe内に流し込んでる
        Observable.Return(new Vector2(0, 1))
            .Subscribe(v => gameObject.transform.position = v);

        //EveryUpdateでUpdateのたびに値流しこんでる
        Observable.EveryUpdate().Subscribe(l => Move(0.01f, 0));
	}
}
