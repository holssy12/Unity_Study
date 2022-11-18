using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Student jhk = new Student();
        jhk.SetDepartment(DepartmentName.CoumputerEngineering);
        print(jhk.department);

        Student ygl = new Student();
        ygl.SetDepartment(DepartmentName.경제학과);

        // 캐스팅으로 int로 변환 가능.
        int[] tution = new int[4];
        tution[(int)DepartmentName.CoumputerEngineering] = 450;
        tution[(int)DepartmentName.경제학과] = 400;
        Debug.Log(tution[(int)DepartmentName.CoumputerEngineering]);
        Debug.Log(tution[3]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
