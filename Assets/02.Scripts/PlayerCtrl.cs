using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;

    // 1회 호출
    void Start()
    {

    }

    // 매 프레임 마다 호출, 화면을 랜더링하는 주기
    void Update()
    {
        v = Input.GetAxis("Vertical"); //Up, Down, W, S // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");// -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("v=" + v); // 콘솔 뷰에 메시지 출력
        Debug.Log("h=" + h); // 콘솔 뷰에 메시지 출력

        //transform.Translate(방향 * 속도 * 변위)
        transform.Translate(Vector3.forward * 0.1f * v);
    }

    /*
        정규화 벡터(Normalized Vector), 유닛 벡터(Unit Vector)

        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)    
    */

    /*
        외부 입력장치 (Input Class)
            - 키보드
            - 마우스
            - 터치
            - 컨트롤러
            - 조이스틱    
    */
}
