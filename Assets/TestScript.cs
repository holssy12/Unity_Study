using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    // 변수는 소문자, 함수는 대문자로 만들자.
    int number;

    public int Number()
    {
        return number;
    }

    // Start is called before the first frame update
    void Start() // C++과 C에서의 main이라 보면 된다.
    {
        // 게임을 시작하게 되면 딱 1번만 실행된다.
        Debug.Log("게임시작");
        Box myBox;
        myBox.x = 10;
        Debug.Log(myBox.x);

        // C# 특징!
        // 객체를 만들면, 바로 메로리 공간이 정적으로 할당되는 게 아니라,
        // 포인터처럼 주소를 가리킬 수 있는 상태가 된다.
        // 즉, 객체로 쓰려면 new를 통해 동적 할당을 해주어야 한다.
        Student jhk = new Student();
        Student jhkClone = jhk; // jhkClone : jhk의 참조형 변수이다.

        Student twl = new Student(25, 2);

        // jhk.age = 30;
        // jhkClone.age = 24;

        jhk.AgeChanger();
        twl.AgeChanger(30);

        Debug.Log("jhk's age is " + jhk.age);
        Debug.Log("twl's age is " + twl.age);

        // static variable 접근.
        // Log도 Debug 클래스의 static method이다...
        //
        // static method는 member variable을 건들 수 없다.
        // 독립된 공간에서 member variable에 접근하게 되면,
        // 어느 객체 공간에 있는 variable인지 알 수가 없기 때문. <--- 속해있는 공간끼리만 접근 가능하다.
        Debug.Log("university: " + Student.university);

        Student.ChangUniversityName("예비군");
        Debug.Log("university: " + Student.university);

    }

    // class, array : call by reference. 나머지는 기본적으로 call by value.
    void StudentChanger(Student stud, int myNum) // stud : call by reference, myNum : call by value
    {
        stud.age = 0;
        myNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // 기본은 1초에 기본 FPS만큼 실행.
        // Debug.Log("게임업데이트");
    }
}
