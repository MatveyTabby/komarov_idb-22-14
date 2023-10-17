using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter_Script : MonoBehaviour
{
    public Text scoreText; // Ссылка на компонент Text
    private int score = 100;

    void Start()
    {
        // Инициализируем текст с начальным значением счетчика
        scoreText.text = "Score: " + score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane")) // Проверка на тег объекта, с которым столкнулись
        {
            --score; // Уменьшаем счетчик
            scoreText.text = "Score: " + score.ToString(); // Обновляем текст на компоненте Text
        }
    }
}
