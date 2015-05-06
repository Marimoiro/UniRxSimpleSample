using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class SkipWhileSample : Base {

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 0.5f);

        //!Input.GetMouseButton(0)の間スキップ
        this.UpdateAsObservable()
            .SkipWhile(_ => !Input.GetMouseButton(0))
            .Subscribe(_ => Move(0.01f, 0));
    }
}
