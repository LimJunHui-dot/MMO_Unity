using System;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;

    
    void Start()
    {
        
    }


    // Update������ Input Manager�� ��ǥ�� �Է��� üũ�� �� ����
    // ���࿡ ������ �Է��� �־����� �װ��� �̺�Ʈ�� ���ĸ� ���ִ� ��������
    // ������ �� �ٵ� �̰��� �������� ������ ����
    // KeyAction�� �ִٰ� ����
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if(KeyAction != null)
            KeyAction.Invoke();
    }
}
