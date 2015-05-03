using UnityEngine;
using System.Collections;
using UniRx;

public class TakeSample : Base {

	// Use this for initialization
	void Start () {
        gameObject.transform.position = new Vector2(0, 0.5f);

        //Takeで最初の100回以外はカット
        Observable.EveryUpdate().Take(100).Subscribe(l => Move(0.01f, 0));
	}
	
}
