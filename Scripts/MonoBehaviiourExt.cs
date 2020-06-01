using System;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// MonoBehaviour 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class MonoBehaviourExt
	{
		//================================================================================
		// 関数（static）
		//================================================================================
		/// <summary>
		/// 条件を満たしたら Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForCondition( this MonoBehaviour self, Func<bool> condition, Action callback )
		{
			CoroutineUtils.CallWaitForCondition( self.gameObject, condition, callback );
		}

		/// <summary>
		/// 1 フレーム待機してから Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForEndOfFrame( this MonoBehaviour self, Action callback )
		{
			CoroutineUtils.CallWaitForEndOfFrame( self.gameObject, callback );
		}

		/// <summary>
		/// 指定された秒数待機してから Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForSeconds( this MonoBehaviour self, float seconds, Action callback )
		{
			CoroutineUtils.CallWaitForSeconds( self.gameObject, seconds, callback );
		}
	}
}