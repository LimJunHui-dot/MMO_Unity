using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // 객체지향적인 관점에서 speed를 굳이 노출시킬 이유가 없음.
    // 해결책:  SeriallizeField
    // C#에서 Reflection을 이용해서 런타임에 객체의 형식(Type)에 대한 정보를 검사하고 조작
    [SerializeField]
    public float _speed = 10.0f;

    void Start()
    {
        Managers.Input.KeyAction -= OnKeyBoard;
        Managers.Input.KeyAction += OnKeyBoard;
    }

    void Update()
    {
        
    }

    void OnKeyBoard()
    {
        // forward는 특정 방향을 나타냄.
        if (Input.GetKey(KeyCode.W))
        {
            // Local이 아니라 World 기준
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            //transform.rotation = Quaternion.LookRotation(Vector3.right);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }

        // transform
    }
}
