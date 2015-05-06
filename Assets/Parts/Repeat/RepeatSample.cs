using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;
using System;

public class RepeatSample : Base
{

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1f);

        int frame = 0;
        var p = this.UpdateAsObservable().Select(_ => frame++)
            //最初の100Frameまでは右に
            .SkipWhile(l =>
            {
                Move(0.01f, 0);
                return frame <= 100;
            })
            //次の100Frameは上に
            .SkipWhile(l =>
            {
                Move(0, 0.01f);
                return frame <= 200;
            })
            .FirstOrDefault()
            .RepeatUntilDestroy(this)
            .Subscribe(l => Debug.Log("到着"));

        
    
    }
}
