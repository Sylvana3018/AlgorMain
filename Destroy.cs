using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject); // используем Destroy для уничтожения и gameObject, чтобы выбрать объект к которому привязан скрипт
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
