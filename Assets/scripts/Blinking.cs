using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        // 
        /*spriteRenderer.enabled:
Thuộc tính enabled quyết định đối tượng có được hiển thị hay không:
true: Đối tượng được hiển thị.
false: Đối tượng bị ẩn.
!spriteRenderer.enabled:

Dấu ! đảo ngược trạng thái hiện tại (từ true sang false và ngược lại).
Ví dụ: Nếu đối tượng đang hiển thị (enabled = true), lệnh này sẽ tắt hiển thị (enabled = false).*/
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}
