using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateRotatorUI : MonoBehaviour {

    private Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        text.text = GameManager.Instance.PinCount.ToString();
    }

    private void OnEnable()
    {
        Pin.OnPinHitRotator += UpdateUI;
    }

    private void OnDisable()
    {
        Pin.OnPinHitRotator -= UpdateUI;
    }

    private void UpdateUI()
    {
        text.text = GameManager.Instance.PinCount.ToString();
    }
}
