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

    private void Awake() // Awake가 실됐다는건 이미 게임오브젝트가 (스크립트에 붙어있는 상태로) 실행이 됐다는것
    {
        if (Instance == null)
        {
            _instance = this; // 나자신 = CharacterManager
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(_instance == this) // 기존에 있는 인스턴스와 내 자신이 다르다면 현재것을 파괴해라
            {
                Destroy(gameObject);
            }
        }
    }

}
