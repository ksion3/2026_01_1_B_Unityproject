using UnityEngine;
using UnityEngine.UI;
public class MyJump1 : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float power = 200f;

    public float Timer = 0.0f;
    public Text TextUI;
    // Update is called once per frame
    void Update()
    {
        Timer = Timer + Time.deltaTime;
        TextUI.text = Timer.ToString();

        if (Input.GetKeyDown(KeyCode.Space))               //스페이스 키를 눌렀을때
        {
            power = power + Random.Range(-100, 200);
            rigidbody.AddForce(transform.up * power);
        }

        if (this.gameObject.transform.position.y > 5 || this.gameObject.transform.position.y < -3)
        {

            Destroy(this.gameObject);
        }
    }
}
