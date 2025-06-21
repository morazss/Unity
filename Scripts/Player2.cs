using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения

    private Rigidbody2D rb1, rb2; // Ссылки на Rigidbody2D для двух персонажей
    private Vector2 moveDirection1, moveDirection2; // Направление движения для каждого персонажа

    void Start()
    {
        // Получаем ссылки на Rigidbody2D для обоих персонажей
        rb1 = GameObject.Find("Player1").GetComponent<Rigidbody2D>();
        rb2 = GameObject.Find("Player2").GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Управление первым персонажем (клавиши H, U, J, K)
        float moveX1 = 0f;
        float moveY1 = 0f;

        if (Input.GetKey(KeyCode.H)) // Движение влево (H)
            moveX1 = -1f;
        if (Input.GetKey(KeyCode.K)) // Движение вправо (K)
            moveX1 = 1f;
        if (Input.GetKey(KeyCode.U)) // Движение вверх (U)
            moveY1 = 1f;
        if (Input.GetKey(KeyCode.J)) // Движение вниз (J)
            moveY1 = -1f;

        moveDirection1 = new Vector2(moveX1, moveY1).normalized;

        // Управление вторым персонажем (клавиши A, W, S, D)
        float moveX2 = 0f;
        float moveY2 = 0f;

        if (Input.GetKey(KeyCode.A)) // Движение влево (A)
            moveX2 = -1f;
        if (Input.GetKey(KeyCode.D)) // Движение вправо (D)
            moveX2 = 1f;
        if (Input.GetKey(KeyCode.W)) // Движение вверх (W)
            moveY2 = 1f;
        if (Input.GetKey(KeyCode.S)) // Движение вниз (S)
            moveY2 = -1f;

        moveDirection2 = new Vector2(moveX2, moveY2).normalized;
    }

    void FixedUpdate()
    {
        // Обновляем движение для обоих персонажей с помощью AddForce
        rb1.linearVelocity = moveDirection1 * moveSpeed; // Для первого персонажа
        rb2.linearVelocity = moveDirection2 * moveSpeed; // Для второго персонажа
    }
}
