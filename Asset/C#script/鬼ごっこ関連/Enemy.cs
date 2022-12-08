using System.Collections.Generic;
//using Takap.Utility;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// �v���C���[��ǔ�����_�~�[�̓G�L�����N�^�[��\���܂��B
/// </summary>
/// <remarks>
/// NavMesh���g�����ړ����@�̃��t�@�����X����
/// </remarks>
public class Enemy : MonoBehaviour
{
    //
    // Inspector
    // - - - - - - - - - - - - - - - - - - - -

    // �ǔ��Ώ�
    //[SerializeField] Player _player;
    [SerializeField] Transform _player;
    // �ړ����x
    [SerializeField] float _moveSpeed = 1f;
    // �ǂꂭ�炢�߂Â����玟�̃|�C���g�Ɉڂ邩
    [SerializeField] float _minDistance = 0.05f;
    // �v���C���[�ւ̌o�H�Čv�Z������Ԋu
    [SerializeField] float _reCalcTime = 0.5f;

    //
    // Fields
    // - - - - - - - - - - - - - - - - - - - -

    // ���̈ړ���
    private Vector2 _nextPoint;

    // �L���b�V����
    private Transform _plyaerTransform;
    private Transform _myTransform;

    // AI�p
    private NavMeshPath _navMeshPath;
    private Queue<Vector3> _navMeshCorners = new();

    // �v�Z�����Ƃ��̃v���C���[�̈ʒu
    Vector3 _calcedPlayerPos;
    // ���ɍČv�Z����܂ł̎���
    private float _elapsed;

    //
    // Runtime impl
    // - - - - - - - - - - - - - - - - - - - -

    public void Awake()
    {
        _myTransform = transform;
        _plyaerTransform = _player.transform;
        _nextPoint = _myTransform.position;
        _navMeshPath = new NavMeshPath();
    }

    public void Update()
    {
        if (_calcedPlayerPos != _plyaerTransform.localPosition)
        {
            _elapsed += Time.deltaTime;
            if (_elapsed > _reCalcTime)
            {
                _elapsed = 0;

                NestStep();
                _calcedPlayerPos = _plyaerTransform.localPosition; // ���[�g�o�����Ƃ��̈ʒu
            }
        }

        Vector2 currentPos = _myTransform.localPosition;
        if (Vector2.Distance(_nextPoint, currentPos) < _minDistance)
        {
            if (_navMeshCorners.Count == 0)
            {
                _nextPoint = _myTransform.localPosition;
                return;
            }
            _nextPoint = _navMeshCorners.Dequeue();
        }

        Vector2 diff = _nextPoint - currentPos;
        if (diff == Vector2.zero)
        {
            return;
        }

        Vector2 step = _moveSpeed * Time.deltaTime * diff.normalized;
        _myTransform.Translate(step);
    }

    private void NestStep()
    {
        // NavMesh�Ōo�H���v�Z����
        // �����̈ʒu �� �v���C���[�̈ʒu
        bool isOk = NavMesh.CalculatePath(_myTransform.position,
            _plyaerTransform.position, NavMesh.AllAreas, _navMeshPath);
        if (!isOk)
        {
            Debug.LogWarning("Failed to NavMesh.CalculatePath.", this);
        }

        _navMeshCorners.Clear();
        _navMeshCorners.EnqueueRange(_navMeshPath.corners);
        _nextPoint = _myTransform.localPosition;
    }
}

/// <summary>
/// <see cref="Queue{T}"/> �̊g���@�\���`���܂��B
/// </summary>
public static class QueueExtension
{
    public static void EnqueueRange<T>(this Queue<T> self, IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            self.Enqueue(item);
        }
    }
}