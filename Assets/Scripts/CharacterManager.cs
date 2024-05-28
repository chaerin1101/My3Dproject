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

    private void Awake() // Awake가 실행됐다는건 이미 게임오브젝트로 (스크립트에 붙어있는 상태에서) 실행이 됐다는것
    {
        if (_instance == null)
        {
            _instance = this; // 나자신 = CharacterManager
            DontDestroyOnLoad(gameObject); // 씬을 이동하더라도 파괴되지않고 정보들이 유지되도록 하는 DontDestroyOnLoad
        }
        else // instance가 null이 아닐수도 있음
        {
            if(_instance == this) // 기존에 있는 인스턴스와 내 자신이 다르다면 현재것을 파괴해라
            {
                Destroy(gameObject);
            }
        }
    }

}
