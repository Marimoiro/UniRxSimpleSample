using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;
using System;
using System.Threading;

public class WWWSample : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        //DLの進行度をプッシュしてくれるObservable
        ScheduledNotifier<float> progress = new ScheduledNotifier<float>();
        var watcher = progress.Subscribe(prog => Debug.Log(prog));
        
        //ダウンロード
        var getter = ObservableWWW.Get("http://corpus.canterbury.ac.nz/descriptions/", null, progress)
            .Subscribe(body =>
        {
            //タイトルを表示
            //Debug.Log(body.Split(new[] { "<title>", "</title>" }, StringSplitOptions.None)[1]);
            Debug.Log("Example Domain");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            //完了したら青に
            GetComponent<SpriteRenderer>().color = Color.blue;
        });

        //Objectが削除されたらどちらも削除
        this.OnDestroyAsObservable().Subscribe(_ => {
            watcher.Dispose();
            getter.Dispose();
        });

    }
}
