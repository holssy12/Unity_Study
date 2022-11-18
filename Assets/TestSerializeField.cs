using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSerializeField : MonoBehaviour
{
    [SerializeField]
    // SerializeField를 쓰거나, List를 public으로 선언하면
    // List를 Unity Editor에서 편집할 수 있다!
    //  ---> Unity Editor를 통해 List에 element를 추가하면,
    //       객체가 생성된다!
    //
    // Array도 public으로 선언하면, 동일하게 동작된다.
    List<int> publicNumList;

    // 직접 만든 Class의 Array를 inspector에서 접근하려면,
    // Class 코드 위에 [System.Serializable]를 써야 한다.
    public Student[] publicStudentArray;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(publicNumList[i]);
            Debug.Log("-------------------------------------------------------");
            Debug.Log(publicStudentArray[i].age);
            // ToString()을 붙여주는 것이 좋다.
            Debug.Log(publicStudentArray[i].department.ToString());
            Debug.Log("-------------------------------------------------------");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
