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

	public ObjectsForPurchase Store;
	public ObjectsForPurchase Purchased;
	public ObjectsForPurchase DefaultStore;

	public SOBool SpinRunning;
	public SOBool BulletRunning;

	private void Start()
	{
		PlayerSpin.value = NormalSpin.Value;
		
		Item.transform.tag = NormalTag.Value;
		ItemSpeed.value = NormalSpeed.Value;

		KillCount.Value = 0;
		CashCount.Value = 60;

		SpinTimer.Value = DefaultTime.Value;
		BulletTimer.Value = DefaultTime.Value;

		SpinRunning.Value = false;
		BulletRunning.Value = false;
		
		Store.ObjectList = DefaultStore.ObjectList;
		Purchased.ObjectList.Clear();
	}
	
}