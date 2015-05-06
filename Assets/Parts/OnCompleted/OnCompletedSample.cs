using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;
using System;

public class OnCompletedSample : Base
{
	// Use this for initialization
	void Start () {
        gameObject.transform.position = new Vector2(0, 1f);


        //100Frameだけ右に行くそれが終わったらもうプッシュされる値がないのでOnCompleteに行って青くなる
        this.UpdateAsObservable()
            .Take(100).Subscribe(
            _ => { Move(0.01f, 0); },
           () => { GetComponent<SpriteRenderer>().color = Color.blue; });
        

    }
	
}
