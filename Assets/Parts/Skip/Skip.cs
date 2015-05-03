using UnityEngine;
using System.Collections;
using UniRx;

public class Skip : Base
{

    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1f);

        //Skipで最初の100回カット
        Observable.EveryUpdate().Skip(100).Subscribe(l => Move(0.01f, 0));
    }

}
