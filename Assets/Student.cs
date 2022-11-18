using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Box
{
    public int x;
    int y;
    int width;
    int height;

    // C언어와 달리 struct에도 함수를 선언할 수 있다.
    // public void BoxChanger() {
    //     x = 10;
    // }
}
// enum : 열거형
// 열거된 순서대로 0, 1, 2,... 의 int 값을 가진다.
public enum DepartmentName
{
    Drawing, OpenMajor, CoumputerEngineering, 경제학과
}

// 나만의 클래스를 만들고 싶으면, 
// 상속받은 MonoBehaviour과 class 안의 내용을 모두 지워준다.

// C#에는 포인터가 없다! 참조형 변수는 있다.

[System.Serializable]   // Student Class를 inspector에서 수정이 가능하게 한다.
public class Student
{
    // 각 객체에 따로 생성되지 않고,
    // 독립적인 공간에 존재하는 static variable.
    public static string university = "인천대학교";
    public DepartmentName department;

    public Box myBox;

    // class의 member variable은 defualt로 private이다.
    public string name;
    public int classNumber;
    public int level;
    public int age;

    public void SetDepartment(DepartmentName name)
    {
        department = name;
    }

    public static void ChangUniversityName(string univName)
    {
        university = univName;
    }

    public Student()
    {
        age = 20;
        level = 1;
    }

    public Student(int newAge, int newLevel)
    {
        age = newAge;
        level = newLevel;
    }

    public void BoxChanger()
    {
        myBox.x = 10;
        // Debug.Log(myBox.x);
    }
    public void AgeChanger(int n)
    {
        age = n;
    }
    public void AgeChanger()
    {
        age = 20;
    }
}
