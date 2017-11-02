using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

// 쓰진 않았지만, 기능 소개용으로 작성
public class VRRecenter : MonoBehaviour {

	public void Recenter()
	{
		// 플레이어의 위치를 VR 장비들의 "센터"로,
		// 플레이어가 보는 방향을 VR 장비들의 "앞쪽 방향" 으로 재정렬 하는 기능
		InputTracking.Recenter();
	}
}
