using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    // UnityScene���ٰ� ��ġ�� �� �ִ� ��� �׷� ��ü�鿡 ���� ��� Ŭ����
    public GameObject prefab;

    GameObject tank;
    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Tank");
        tank = Instantiate(prefab);

        Destroy(tank, 3.0f);
    }

    void Update()
    {
        
    }
}
