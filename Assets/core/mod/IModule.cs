//ģ����࣬ͨ��ģ����һ���߼��϶����Ĺ��ܵ�
using System;
namespace core
{
    public interface IModule
    {
        void Start();
        void Update();
        void Dispose();
        bool IsEnable();
    }
}

