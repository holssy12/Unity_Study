using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Generic Type
public class BackPack<T>
{
    // 원래는 public int obj 라고 쓸 것을
    // 타입 T로 퉁친다...
    // 대신, 여러개의 변수를 쓸 수는 없고, 하나만으로 쓸 수 있다.
    //
    // T가 Class의 형식을 담당한다!
    public T obj;

    public void ChangeObj(T param)
    {
        obj = param;
    }
}
