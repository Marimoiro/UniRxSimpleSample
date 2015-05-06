using UnityEngine;
using System.Collections;
using UniRx;
using System;

public class TimerSample : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //5秒たったらプッシュ
        Observable.Timer(TimeSpan.FromSeconds(5)).Subscribe(_ =>
        {
            //青くする
            GetComponent<SpriteRenderer>().color = Color.blue;
        }).AddTo(this);
	}
	
}
