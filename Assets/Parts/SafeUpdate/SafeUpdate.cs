using UnityEngine;
using System.Collections;
using UniRx;
using System;

public class SafeUpdate : Base
{

	// Use this for initialization
	void Start () {
        
        gameObject.transform.position = new Vector2(0, 1f);

        //5秒後にgameObjectが死ぬ
        Observable.Timer(TimeSpan.FromSeconds(5)).Subscribe(_ => Destroy(gameObject));

        Observable.EveryUpdate().Subscribe(l => Move(0.01f, 0))
            .AddTo(this);
	}
}
