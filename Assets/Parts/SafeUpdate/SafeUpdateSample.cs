using UnityEngine;
using System.Collections;
using UniRx;
using System;

public class SafeUpdateSample : Base
{

	// Use this for initialization
	void Start () {
        
        gameObject.transform.position = new Vector2(0, 1f);

        //5秒後にgameObjectが死ぬ
        Observable.Timer(TimeSpan.FromSeconds(5))
            .Subscribe(_ => Destroy(gameObject));

        //0.5秒ごとに0.05右に移動
        Observable.Interval(TimeSpan.FromMilliseconds(500))
            .TakeUntilDestroy(this)
            .Subscribe(l => Move(0.1f, 0))
            .AddTo(this);//これを消すと例外
	}
}
