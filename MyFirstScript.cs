using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour { // MonoBehaviour 상속

    private void Awake() // 유니티가 자동으로 실행시킴
        // Awake 함수는 항상 실행되니 가볍게 설정하자 (Inspector에 등록되어 있다면...)
    {
        Debug.Log("Awake Called");
    }


    // Use this for initialization
    void Start ()
    {
        Debug.Log("Start Called");
        Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () // Update 함수는 매 순간 실행된다. 
    {
        Debug.LogWarning("Update Called");
	}

    private void LateUpdate() // 이름이 LateUpdate이지만, 실행 순서는 Update 다음에 실행된다.
    {
        Debug.Log("LateUpdate Called");
    }
}
