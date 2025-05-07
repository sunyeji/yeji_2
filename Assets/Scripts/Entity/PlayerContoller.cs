using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// BaseController를 상속받는 Player 전용 컨트롤러
public class PlayerController : BaseController
{
    // 부모 클래스에서 선언된 HandleAction을 덮어써서 플레이어만의 입력 처리 구현
    protected override void HandleAction()
    {
        // 키보드 입력 받아오기 (A/D/←/→ → x축, W/S/↑/↓ → y축)
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // 입력된 방향을 movementDirection으로 설정
        // .normalized는 대각선 이동 시 속도 일관성을 위해 사용
        movementDirection = new Vector2(horizontal, vertical).normalized;
    }
}
