using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class UnityAdsManager : MonoBehaviour 
{
	static UnityAdsManager _instance;

	/// <summary>
	/// Get instance.
	/// </summary>
	/// <returns>The instance.</returns>
	public static UnityAdsManager GetInstance () {
		if (null == _instance) {
			GameObject go = new GameObject ("UnityAdsManager");
			_instance = go.AddComponent<UnityAdsManager>();
		}
		return _instance;
	}
	 
	[SerializeField]
	string appId = "14775";

	public void Init () {

	}

	public void ShowAds () {

	}
}
