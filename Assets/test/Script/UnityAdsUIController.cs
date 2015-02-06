using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnityAdsUIController : UIBehaviour
{
	protected override void Awake ()
	{
		base.Awake ();

		OnChangeGameState (GameController.gameState.Value);
		GameController.gameState.AddListener(OnChangeGameState);
		
		GetComponent<Button>().onClick.AddListener( OnAdsClick );

		UnityAdsManager.GetInstance ().Init ();
	}

	protected override void OnDestroy()
	{
		if( GameController.Instance != null )
			GameController.gameState.RemoveListener(OnChangeGameState);
		
		GetComponent<Button>().onClick.RemoveListener( OnAdsClick );
	}

	void OnChangeGameState (GameController.GameState state)
	{
		switch( state )
		{
		case GameController.GameState.Title:
			gameObject.SetActive(false);
			break;
		case GameController.GameState.GameOver:
			gameObject.SetActive(true);
			break;
		case GameController.GameState.Play:
			gameObject.SetActive(false);
			break;
		case GameController.GameState.Retry:
			gameObject.SetActive(false);
			break;
		}
	}

	public void OnAdsClick ()
	{
		// do something when click the ADS button.
		UnityAdsManager.GetInstance ().ShowAds ();
	}
}
