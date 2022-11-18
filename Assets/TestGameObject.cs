using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameObject : MonoBehaviour
{
    // public으로 선언하면, inspector에서 myObject에 접근 가능.
    // 마찬가지로, [SerializeField]로도 가능.
    //
    // 접근 제한자를 따로 지정해주지 않으면, default로 private이다.
    // public으로 만들어주어야, 해당 스크립트 외부에서 접근 가능!
    [SerializeField]
    // GameObject myObject;

    GameObject[] myObjectArr;

    // Start is called before the first frame update
    void Start()
    {
        /*
        // Start가 시작하면, GameObject의 이름이 "나의 오브젝트"로 바뀐다.
        myObject.name = "나의 오브젝트";

        // Vector3는 struct 이다. 즉, 일반 변수와 같이 값 형식의 데이터이다. ( class는 참조 형식 )
        // 그래서, 선언 시에 이미 공간이 만들어지기 때문에, new를 통한 동적할당을 해줄 필요는 없지만,
        // 왜인지 컴파일 에러가 발생한다... 그냥 붙여주자.
        Vector3 myPosition = new Vector3();
        myPosition.x = 10;
        myPosition.y = 20;

        // transform은 myObject의 member variable이다.
        myObject.transform.position = myPosition;
        */

        for (int i = 0; i < 4; i++)
        {
            myObjectArr[i].name = "정현이의 소환물 " + i.ToString();
            Vector3 pos = new Vector3();
            pos.x = i * 3;
            pos.y = i * 3;
            myObjectArr[i].transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
