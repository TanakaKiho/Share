using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Arrow : MonoBehaviour
{
    //private Animator animator;              //�A�j���[�^�[���g��
    private NavMeshAgent agent;             //NavMeshAgent���g��
    public Transform target;                //�^�[�Q�b�g�ɐݒ�ł���悤�ɂ���
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent(Animator);    //�A�j���[�^�[�����擾
        agent = GetComponent<NavMeshAgent>();   //NavMeshAgent�����擾
        agent.destination = target.position;    //�G(agent)���v���[���[(target)�Ɍ�����
        rb = GetComponent<Rigidbody>();
}

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;    //�v���[���̂ق��Ɍ������Ă���
    }
}
