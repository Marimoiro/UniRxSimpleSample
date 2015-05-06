using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class SkipSample : Base
{

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1f);

        //Skipで最初の100回カット
        this.UpdateAsObservable().
            Skip(100).
            Subscribe(l => Move(0.01f, 0));
    }

}
