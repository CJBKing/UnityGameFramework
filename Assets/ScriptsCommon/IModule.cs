//ģ����࣬ͨ��ģ����һ���߼��϶����Ĺ��ܵ�
using System;
public class IModule
{
    public virtual void Start() { }
    public virtual void Update() { }
    public virtual void Dispose() { }
    public bool Enable = true;
}


