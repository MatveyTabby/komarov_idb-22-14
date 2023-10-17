using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter_Script : MonoBehaviour
{
    public Text scoreText; // ������ �� ��������� Text
    private int score = 100;

    void Start()
    {
        // �������������� ����� � ��������� ��������� ��������
        scoreText.text = "Score: " + score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plane")) // �������� �� ��� �������, � ������� �����������
        {
            --score; // ��������� �������
            scoreText.text = "Score: " + score.ToString(); // ��������� ����� �� ���������� Text
        }
    }
}
