using UnityEngine;

/// <summary>
/// �w�i���������ɃX�N���[��������R���|�[�l���g
/// </summary>
public class BackgroundController : MonoBehaviour
{
    [SerializeField] SpriteRenderer _bgImage;
    [SerializeField] float _scrollSpeed = 2.5f;
    Transform _bg0;
    Transform _bg1;
    float _bgImageHeight;

    void Start()
    {
        // �R�s�[����ׂ�
        _bg0 = _bgImage.transform;
        _bgImageHeight = _bgImage.bounds.size.y;
        var bgImageClone = Instantiate(_bgImage, transform);
        _bg1 = bgImageClone.transform;
        _bg1.Translate(0, _bgImageHeight, 0);
    }

    void Update()
    {
        // ���Ɉړ�����
        _bg0.Translate(0, -1 * _scrollSpeed * Time.deltaTime, 0);
        _bg1.Translate(0, -1 * _scrollSpeed * Time.deltaTime, 0);

        // ���ɗ������Ɉړ�����
        if (_bg0.position.y <= -1 * _bgImageHeight)
        {
            _bg0.Translate(0, 2 * _bgImageHeight, 0);
        }

        if (_bg1.position.y <= -1 * _bgImageHeight)
        {
            _bg1.Translate(0, 2 * _bgImageHeight, 0);
        }
    }
}
