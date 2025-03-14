using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    // UnityScene에다가 배치할 수 있는 모든 그런 객체들에 대한 기반 클래스
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
