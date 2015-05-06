using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class FirstSample : Base
{

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1f);

        //クリックされたら右に1.5動かす(但し1回だけ)
        this.UpdateAsObservable()
            .First(l => Input.GetMouseButton(0))
            .Subscribe(l => Move(1.5f, 0));
    }
}
