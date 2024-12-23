using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    //Dữ liệu đại diện cho một đối tượng trong game (Prefab).
    //Đối tượng lưu trữ Prefab vụ nổ (hiệu ứng khi kẻ địch bị phá hủy).
    public GameObject exlosionPrefab;

    //Được gọi khi một đối tượng khác có Collider2D đi vào vùng Trigger của kẻ địch.
    //collision: Đại diện cho đối tượng va chạm.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Khi có đối tượng khác đi vào vùng Trigger của kẻ địch, hàm Die()
        // sẽ được gọi ngay lập tức để phá hủy đối tượng.
        Die();
    }

    //Hủy đối tượng hiện tại (gameObject) ra khỏi cảnh (scene).
    private void Die()
    {
        var explosion = Instantiate(exlosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 0.2f);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
