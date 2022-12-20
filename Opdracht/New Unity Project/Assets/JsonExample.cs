using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JsonExample : MonoBehaviour
{
    void Start()
    {
       
        Dictionary<string, object> points = new Dictionary<string, object>
            {
                { "name", "John" },
                { "age", 30 },
                { "city", "New York" }
            };

        // Extract the values from the dictionary
        string name = (string)points["name"];
        int age = (int)points["age"];
        string city = (string)points["city"];

        //System.
        // Display the values as a 3D object
        GameObject textObject = new GameObject("Text");
        TextMesh textMesh = textObject.AddComponent<TextMesh>();
        textMesh.text = "Name: " + name + "\nAge: " + age + "\nCity: " + city;
        textMesh.fontSize = 24;
        textMesh.color = Color.black;
        textObject.transform.position = new Vector3(0, 0, 0);
    }
}


