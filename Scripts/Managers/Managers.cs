using UnityEngine;

public class Managers : MonoBehaviour
{
    // �̱��� ����
    static Managers s_Instance; // ���ϼ��� ����ȴ�
    // �� �̻� �ν��Ͻ��� �ܺο��� �����ϱ� ������ �����ϱ� public ����
    static Managers Instance { get { Init(); return s_Instance; } } // ������ �Ŵ����� ����´�(�ܺο��� ����� �� ������)
    
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
            // ���� ������Ʈ�� �̸����� ã�� ���� ���ϰ� �ſ� ���� �κ�
            // �߰��� ����� ����
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>(); 
            }

            // ���� ������� ����
            DontDestroyOnLoad(go);
            s_Instance = go.GetComponent<Managers>();
        }
    }
}
