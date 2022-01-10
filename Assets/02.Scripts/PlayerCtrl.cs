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
}
