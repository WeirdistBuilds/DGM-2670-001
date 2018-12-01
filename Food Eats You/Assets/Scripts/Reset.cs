using UnityEngine;

public class Reset : MonoBehaviour {

	public SOFloat PlayerSpin;
	public SOFloat NormalSpin;
	
	public GameObject Item;
	public SOString NormalTag;
	public SOFloat ItemSpeed;
	public SOFloat NormalSpeed;

	public SOInt KillCount;
	public SOInt CashCount;

	public SOInt SpinTimer;
	public SOInt BulletTimer;
	public SOInt DefaultTime;

	private void Start()
	{
		PlayerSpin.value = NormalSpin.Value;
		
		Item.transform.tag = NormalTag.Value;
		ItemSpeed.value = NormalSpeed.Value;

		KillCount.Value = 0;
		CashCount.Value = 0;

		SpinTimer.Value = DefaultTime.Value;
		BulletTimer.Value = DefaultTime.Value;
	}
}