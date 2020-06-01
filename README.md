# Uni Coroutine Utils

どこからでもコルーチンを使用できるようにするクラス  

## 使用例

```cs
using System.Collections;
using UniCoroutine;
using UnityEngine;

public class Example
{
    private void Run()
    {
        // 1 フレーム後にコールバックを実行
        CoroutineUtils.CallWaitForEndOfFrame( () => Debug.Log( "ピカチュウ" ) );

        // 指定された秒数待機してからコールバックを実行
        CoroutineUtils.CallWaitForSeconds( 1, () => Debug.Log( "ピカチュウ" ) );
        
        // 指定された条件を満たしたらコールバックを実行
        CoroutineUtils.CallWaitForCondition( () => true, () => Debug.Log( "ピカチュウ" ) );

        // コルーチンを実行
        CoroutineUtils.StartCoroutine( Coroutine() );
    }

    private IEnumerator Coroutine()
    {
        yield break;
    }
}
```
