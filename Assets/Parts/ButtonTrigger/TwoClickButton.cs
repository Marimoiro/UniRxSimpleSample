using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class TwoClickButton : Base
{

    public Button Button;
    // Use this for initialization
    void Start()
    {
        gameObject.transform.position = new Vector2(0, 1.5f);

        //1回目はスキップする
        Button.onClick.AsObservable().Skip(1)
            .Subscribe(u => Move(1f, 0));
    }
}
