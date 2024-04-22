using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScaleButton : MonoBehaviour
{
    public Button button; // ปุ่มที่ต้องการให้โพว์ม
    public float scaleFactor = 0.01f; // ขนาดที่ต้องการให้โพว์มขึ้นมาทีละน้อย
    public float scaleSpeed = 0.01f; // ความเร็วในการเปลี่ยนขนาด

    void Start()
    {
        // เริ่ม Coroutine เพื่อทำการโพว์ม Button ขึ้นมา
        StartCoroutine(ScaleButtonUp());
    }

    IEnumerator ScaleButtonUp()
    {
        // ขนาดเริ่มต้นของ Button
        Vector3 originalScale = button.transform.localScale;

        // เพิ่มขนาดของ Button จนกว่าจะถึงขนาดที่ต้องการ
        while (button.transform.localScale.x < 1f)
        {
            // เพิ่มขนาดของ Button
            button.transform.localScale += Vector3.one * scaleFactor * scaleSpeed;
            yield return new WaitForSeconds(scaleSpeed);
        }

        // กำหนดให้ขนาดของ Button เป็นค่าที่เท่ากับ 1
        button.transform.localScale = Vector3.one;
    }
}
