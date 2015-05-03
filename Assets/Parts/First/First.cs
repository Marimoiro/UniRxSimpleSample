using UnityEngine;
using System.Collections;
using UniRx;

public class First : Base
{

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1f);

        //100Frameたったら1.5右に動かす
        Observable.EveryUpdate().First(l => l >= 100).Subscribe(l => Move(1.5f, 0));

        

    }
}
