using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //�г��� �Է��� �޾Ƽ� �����ϰ� ��ư�� Ŭ���� �� ���� ������ �̵��ϱ�

    [SerializeField] private TMP_InputField  nickName;
    [SerializeField] private Button startButton;


    private void Start()
    {
        PlayerPrefs.SetString("nickName", nickName.text);        
        startButton.onClick.AddListener(() => SceneManager.LoadScene("Wasabi 2"));
    }











}
