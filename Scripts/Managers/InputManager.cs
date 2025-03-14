using System;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;

    
    void Start()
    {
        
    }


    // Update문에서 Input Manager가 대표로 입력을 체크를 한 다음
    // 만약에 실제로 입력이 있었으면 그것을 이벤트로 전파를 해주는 형식으로
    // 구현을 할 텐데 이것이 전형적인 리스너 패턴
    // KeyAction이 있다고 전파
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if(KeyAction != null)
            KeyAction.Invoke();
    }
}
