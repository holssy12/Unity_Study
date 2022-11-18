using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollections : MonoBehaviour
{
    /*
        Class : Array, List, Dictionary
    */

    // Student 객체 공간을 가리킬 수 있는 array 생성.
    Student[] arr;

    // int 변수 공간을 가리킬 수 있는 List 생성.
    List<int> myList;

    // Dictionary
    Dictionary<string, Student> myDict;


    // Start is called before the first frame update
    void Start()
    {
        // Student 객체 공간을 가리킬 수 있는 변수를 담는 Array를 만들어 공간 4개 할당. 
        arr = new Student[4];

        for (int i = 0; i < 4; i++)
        {
            // Array 원소에 실제 객체를 만들어서 가리키도록 할당.
            arr[i] = new Student();
            arr[i].age = 20 + i;
            Debug.Log(arr[i].age);
        }
        // arr[1]이 arr[0]과 같은 객체 공간을 가리키도록 바꾼다.
        arr[1] = arr[0];
        arr[0].age = 55;
        Debug.Log(arr[1].age);


        Debug.Log("----------------------------------------------------------------\n");


        // 이제 int 공간을 가리킬 수 있도록 되었지만,
        // 실제로 가리키는 공간은 없는 상태.
        myList = new List<int>();

        // add를 통해, 가리키는 공간을 채운다.
        myList.Add(10); // 0번
        myList.Add(40); // 1번
        myList.Add(60); // 1번
        myList[1] = 20;

        // Debug.Log(myList[0]);
        // Debug.Log(myList[1]);
        for (int i = 0; i < myList.Count; i++)
        {
            Debug.Log(myList[i]);
            Debug.Log(myList.Count);
        }


        Debug.Log("----------------------------------------------------------------\n");


        myDict = new Dictionary<string, Student>();
        Student jh = new Student();
        jh.age = 24;
        myDict.Add("정현", jh);
        Debug.Log(myDict["정현"].age);


        Debug.Log("----------------------------------------------------------------\n");


        BackPack<int> myIntBag = new BackPack<int>();
        myIntBag.obj = 10;

        BackPack<string> myStringBag = new BackPack<string>();
        myStringBag.obj = "정현이의 가방";

        BackPack<Student> myStudentBag = new BackPack<Student>();
        myStudentBag.obj = new Student();
        myStudentBag.obj.age = 24;

        Debug.Log(myStudentBag.obj.age);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
