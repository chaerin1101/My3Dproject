using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManager>();
            }
            return _instance;
        }
    }

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }

    private void Awake() // Awake�� ����ƴٴ°� �̹� ���ӿ�����Ʈ�� (��ũ��Ʈ�� �پ��ִ� ���¿���) ������ �ƴٴ°�
    {
        if (_instance == null)
        {
            _instance = this; // ���ڽ� = CharacterManager
            DontDestroyOnLoad(gameObject); // ���� �̵��ϴ��� �ı������ʰ� �������� �����ǵ��� �ϴ� DontDestroyOnLoad
        }
        else // instance�� null�� �ƴҼ��� ����
        {
            if(_instance == this) // ������ �ִ� �ν��Ͻ��� �� �ڽ��� �ٸ��ٸ� ������� �ı��ض�
            {
                Destroy(gameObject);
            }
        }
    }

}
