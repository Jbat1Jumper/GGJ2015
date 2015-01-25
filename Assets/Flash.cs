using UnityEngine;
using System.Collections;

public class Flash : MonoBehaviour {
	public float Interval = 0.1F;
	public float Randomness = 0.0F;

	public bool IsFlashing = false;

	void Start() {
		sr = this.GetComponent<SpriteRenderer>();
	}
	private SpriteRenderer sr;
	private float remainingTime = 0.2F;
	private float remainingFlashTime = -300.0F;
	// Update is called once per frame
	void Update () {
		if (!IsFlashing)
			return;
		remainingFlashTime -= Time.deltaTime;
		remainingTime -= Time.deltaTime;
		if (remainingFlashTime <= 0 && remainingFlashTime > -200.0F) {
			IsFlashing = false;
						return;
				}
		if (remainingTime <= 0) {
			remainingTime = Interval + Random.Range(0, Randomness);
			sr.enabled = !sr.enabled;
		}
	}

	void FlashFor(float Seconds) {
		remainingFlashTime = Seconds;
		IsFlashing = true;
	}
}
