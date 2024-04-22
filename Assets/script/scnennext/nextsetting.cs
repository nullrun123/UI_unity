using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextsetting : MonoBehaviour
{
    public float cooldownTime = 1f; // เวลาที่ต้องการให้มีการ cooldown ก่อนเปลี่ยนฉาก

    // ฟังก์ชันเรียกเมื่อกดปุ่มเปลี่ยนฉาก
    public void LoadSceneWithCooldown()
    {
        StartCoroutine(LoadSceneWithCooldownCoroutine());
    }

    // Coroutine เพื่อทำการ cooldown ก่อนเปลี่ยนฉาก
    private IEnumerator LoadSceneWithCooldownCoroutine()
    {
        // พักเวลาตาม cooldownTime
        yield return new WaitForSeconds(cooldownTime);

        
        SceneManager.LoadScene("setting");
    }

    // ฟังก์ชันเรียกเมื่อกดปุ่มออกจากเกม
    public void Quit()
    {
        Application.Quit();
    }
}
