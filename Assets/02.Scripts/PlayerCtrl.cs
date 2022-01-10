using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float v;
    private float h;
    private float r;

    public float speed = 8.0f;

    // 1회 호출
    void Start()
    {

    }

    // 매 프레임 마다 호출, 화면을 랜더링하는 주기, 호출간격이 불규칙
    void Update()
    {
        v = Input.GetAxis("Vertical"); //Up, Down, W, S // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");// -1.0f ~ 0.0f ~ +1.0f
        r = Input.GetAxis("Mouse X");

        // transform.Translate(방향 * 속도 * 변위)
        // transform.Translate(Vector3.forward * 0.1f * v); //전진/후진
        // transform.Translate(Vector3.right * 0.1f * h);   //좌/우

        // 벡터의 덧셈 연산
        // Vector3 moveDir = (전후진벡터) + (좌우벡터)
        //이동처리
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        transform.Translate(moveDir.normalized * Time.deltaTime * speed);

        //회전처리
        transform.Rotate(Vector3.up * Time.deltaTime * 80.0f * r);

        //Debug.Log("정규화 이전 벡터 =" + moveDir.magnitude);//정규화 이전의 벡터 크기
        //Debug.Log("정규화 벡터 =" + moveDir.normalized.magnitude); //정규화 벡터
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
