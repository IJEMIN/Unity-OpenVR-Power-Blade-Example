### ENG
# Unity-OpenVR-Power-Blade-Example

Easy to use template for Unity OpenVR Input System. Works for Oculus Rift and Vive

### KOR
# 유니티 OpenVR 파워 블레이드 예제
오큘러스와 바이브에 대응되는, 플러그인 없이 간결한 유니티 VR 입력 예제 입니다.


## 설명
유니티의 OpenVR API 를 통해, 외부 애셋고 플러그인 없이 간결하게 Unity VR 컨트롤러의 위치와 회전을 트래킹 합니다.
또한 VR 컨트롤러의 입력을 외부 플러그인 없이 받는 방법으로 동작합니다.

템플릿으로 사용가능하도록 캡슐화가 되어있습니다.
주석을 달아두었습니다.

## 원리
(SwordController.cs 주석에서 발최)
  유니티는 OpenVR API 를 내장하고 있다.
	
  이것으로 VR 입력을 InputManager 에서 조이스틱 입력으로서 받을 수 있다.

	1. VR 인풋 테이블 참고하기.
	
	VR 인풋 테이블을 참고하기 위해 링크로 이동한다. (https://docs.unity3d.com/Manual/OpenVRControllers.html) InputManager 에서 어떤 조이스틱 입력 번호가 VR 컨트롤러의 버튼에 대응된느지 체크할 수 있다.

	2. InputManager 에서 VR 용 입력 설정을 만든다.
	Project Settings > InputManager 로 이동한다.
	
	(미리 만들어진 InputManager 값들을 확인 가능하다.)

	이름은 마음대로 지정가능하다. 이 예제의 경우 HTC Vive 컨트롤러의 왼쪽 검지 방아쇠(트리거) 버튼과 Oculus Rift 터치 컨트롤러의 왼쪽 검지 방아쇠(트리거) 버튼에 연동되는 입력 세팅 이름을 "LeftIndexTrigger" 로 지었다.

	인풋 테이블에서 Vive 왼손 검지 방아쇠와 Ocluls Rift 왼손 검지 방아쇠는 Joystick 9 th Axis 로 표시되어있다.
	
	따라서 LeftIndexTrigger 에 대응되는 조이스틱 Axis 는 9 th Axis 로 지정되어 있다.
	
	위의 내용은 미리 세팅된 값에서 확인 가능하다.

	2. 일반 게임에서 사용하듯이 Input.GetAxis 를 사용하면 된다.

	0.1f(10%) 이상 트리거가 눌려질시 해당 버튼을 누른것으로 보았다.

	GetAxis 는 입력값을 부드럽게 꺾어준다. 별 상관은 없지만 입력을 즉시 받기 위해, 보간이 없는 GetAxisRaw 를 사용했다.



# 레퍼런스
이것을 기반으로 다시 만든 프로젝트 입니다. https://github.com/ozlael/UnityDemo_InputForOVR
