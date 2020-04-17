using System;
using UnityEngine;

namespace UniCoroutine
{
	/// <summary>
	/// GameObject 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class GameObjectExt
	{
		//================================================================================
		// 関数（static）
		//================================================================================
		/// <summary>
		/// 条件を満たしたら Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForCondition( this GameObject self, Func<bool> condition, Action callback )
		{
			CoroutineUtils.CallWaitForCondition( self, condition, callback );
		}

		/// <summary>
		/// 1 フレーム待機してから Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForEndOfFrame( this GameObject self, Action callback )
		{
			CoroutineUtils.CallWaitForEndOfFrame( self, callback );
		}

		/// <summary>
		/// 指定された秒数待機してから Action デリゲートを呼び出します
		/// </summary>
		public static void CallWaitForSeconds( this GameObject self, float seconds, Action callback )
		{
			CoroutineUtils.CallWaitForSeconds( self, seconds, callback );
		}
	}
}