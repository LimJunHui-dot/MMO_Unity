using UnityEngine;

public class Managers : MonoBehaviour
{
    // 싱글톤 구현
    static Managers s_Instance; // 유일성이 보장된다
    // 더 이상 인스턴스도 외부에서 접근하길 원하지 않으니까 public 삭제
    static Managers Instance { get { Init(); return s_Instance; } } // 유일한 매니저를 갖고온다(외부에서 사용할 때 무조건)
    
    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if(s_Instance == null)
        {
            // 게임 오브젝트를 이름으로 찾는 것은 부하가 매우 심한 부분
            // 중간에 디버깅 실행
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>(); 
            }

            // 거의 사라지지 않음
            DontDestroyOnLoad(go);
            s_Instance = go.GetComponent<Managers>();
        }
    }
}
