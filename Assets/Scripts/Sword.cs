using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 예시용 무기 스크립트: 힘을 충전하면 붉게 빛나는 기능을 가졌다.
/*
	게임이 처음 시작되었을때, 자신의 랜더러를 끈다.

	Activate 함수가 발동되면 자신의 랜더러를 켠다.

	Charge 함수가 발동되면 빛나는 정도를 높인다.

	평상시 Update 문에서는 빛나는 정도를 지속적으로 낮추고 있다.
 */
public class Sword : MonoBehaviour {

	// 힘이 충전됬을때 에미션(발광용) 컬러
	public Color chargeColor = Color.red;
	// 모델의 랜더러
	private Renderer swordRenderer;
	// 현재의 에미션 컬러
	private Color currentEmissionColor = Color.black;

	// 0.0(0%)~1.0(100%) 사이의 현재 충전된 힘의 퍼센티지
	private float powerRatio = 0f;
	void Start()
	{
		swordRenderer = GetComponent<Renderer>();
		swordRenderer.material.SetColor("_EmissionColor",Color.black
		);

		swordRenderer.enabled = false;
	}

	// 바깥에서 힘을 충전하기 위해 호출
	public void Charge()
	{
		powerRatio += Time.deltaTime * 2;
	}

	void Update()
	{
		// 아무것도 안하고 있어도 지속적으로 힘이 줄어듬
		powerRatio -= Time.deltaTime;
		
		// 값이 0과 1 사이를 벗어나지 못하게 꺽어줌
		powerRatio = Mathf.Clamp01(powerRatio);

		// 컬러 = 중간값(시작컬러,타겟컬러,퍼센티지)
		currentEmissionColor = Color.Lerp(Color.black,chargeColor,powerRatio);

		// 마테리얼의 에미션 컬러를 지정
		swordRenderer.material.SetColor("_EmissionColor",currentEmissionColor);
	}

	// 랜더러를 켜기
	public void Activate()
	{
		swordRenderer.enabled = true;
	}

}
