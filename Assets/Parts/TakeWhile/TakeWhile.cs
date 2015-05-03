using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class TakeWhile : Base
{
    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1.5f);

        //Takeでxが2を超えたらそれ以降はカット
        this.UpdateAsObservable()
            .TakeWhile(l => gameObject.transform.position.x <= 2)
            .Subscribe(l => Move(0.01f, 0));
    }

}
