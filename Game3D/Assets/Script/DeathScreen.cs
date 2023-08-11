using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public Transform[] checkpoints; // Mảng lưu trữ các checkpoint
    private Vector3 spawnPoint; // Vị trí xuất hiện

    void Start()
    {
        Button button = GetComponent<Button>(); // Lấy tham chiếu đến component Button
        button.onClick.AddListener(ReturnToCheckPoint); // Đăng ký hàm ReturnToCheckPoint khi button được nhấn
    }

    void Update()
    {

    }

    private void ReturnToCheckPoint()
    {
        // Kiểm tra xem người chơi đã tiếp xúc với checkpoint chưa
        for (int i = 0; i < checkpoints.Length; i++)
        {
            if (transform.position == checkpoints[i].position)
            {
                // Cập nhật vị trí xuất hiện khi tiếp xúc với checkpoint
                spawnPoint = checkpoints[i].position;
                // Không cần hủy checkpoint ở đây
                break;
            }
        }

        // Đặt vị trí của người chơi thành vị trí checkpoint
        transform.position = spawnPoint;

        // Tạo Empty GameObject "DeathScreen" và đặt vị trí tương tự như vị trí hiện tại của người chơi
        GameObject deathScreenObject = new GameObject("DeathScreen");
        deathScreenObject.transform.position = transform.position;
    }


    //public void loadMainMenu()
    //{
    //    SceneManager.LoadScene("MainMenu");
    //}
}
