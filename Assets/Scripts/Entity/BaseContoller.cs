using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 모든 캐릭터 컨트롤러의 부모 클래스
public class BaseController : MonoBehaviour
{

    protected virtual void Update()
    {
        HandleAction();  // 자식 클래스에서 오버라이드된 HandleAction 실행됨
    }

    // Rigidbody2D 컴포넌트를 참조 (이동에 사용)
    protected Rigidbody2D _rigidbody;

    // 현재 이동 방향 (자식 클래스에서 조작 가능)
    protected Vector2 movementDirection = Vector2.zero;

    // movementDirection을 외부에서 읽을 수 있도록 public 프로퍼티로 제공
    public Vector2 MovementDirection => movementDirection;

    // 유니티 생명주기: 게임이 시작될 때 호출
    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트 가져오기
    }

    // 유니티 생명주기: 물리 관련 연산은 FixedUpdate에서 수행
    protected virtual void FixedUpdate()
    {
        Move(movementDirection); // 설정된 방향으로 실제 이동 처리
    }

    // 자식 클래스에서 오버라이드해서 입력 또는 행동 처리용
    protected virtual void HandleAction()
    {
        // 기본 동작 없음 (자식이 구현)
    }

    // Rigidbody2D에 velocity 값을 넣어 이동 구현
    private void Move(Vector2 direction)
    {
        float moveSpeed = 5f; // 이동 속도 (필요하면 변수로 뺄 수 있음)
        _rigidbody.velocity = direction * moveSpeed;
    }
}
