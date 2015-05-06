using UnityEngine;
using System.Collections;
using UniRx;
using System;


public class IntevalSample : Base {

	// Use this for initialization
	void Start () {

        //5秒たったらプッシュ
        Observable.Interval(TimeSpan.FromMilliseconds(50)).Subscribe(l =>
        {
            //緑色に近づける
            GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.green, l / 200.0f);
        }).AddTo(this);
    }
	
}
