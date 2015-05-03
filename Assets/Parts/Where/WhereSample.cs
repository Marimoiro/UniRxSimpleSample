using UnityEngine;
using System.Collections;
using UniRx;

public class WhereSample : Base {

	// Use this for initialization
	void Start () {
        //Returnで(0,1)という値をSubscribe内に流し込んでる
        Observable.Return(new Vector2(0, 0.5f)).Subscribe(v => gameObject.transform.position = v);

        //Whereで2回に1回しかSubscribe内まで値が来ないようにしてる
        Observable.EveryUpdate().Where(l => l % 2 == 0).Subscribe(l => Move(0.01f, 0));
	}
	
}
