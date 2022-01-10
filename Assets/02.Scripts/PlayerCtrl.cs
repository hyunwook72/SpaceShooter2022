using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    // 1회 호출
    void Start()
    {

    }

    // 매 프레임 마다 호출, 화면을 랜더링하는 주기
    void Update()
    {
        //transform.position += new Vector3(0, 0, 0.1f);
        transform.Translate(Vector3.forward * 0.1f);
    }

    /*
        정규화 벡터(Normalized Vector), 유닛 벡터(Unit Vector)

        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)    
    */
}
