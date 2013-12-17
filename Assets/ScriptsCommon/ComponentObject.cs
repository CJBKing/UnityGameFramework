//ģ����Unity��Component������ʹ�ö�̬�������ĳ��������ӹ��ܡ�������Ҫ������MonoBehavior��������
using System;
using System.Collections.Generic;

public class ComponentObject
{
    public ComponentObject()
    {
    }

    private List<ComponentObject> childs = null;
    public T AddComponent<T>() where T : ComponentObject, new()
    {
        if (childs == null)
        {
            childs = new List<ComponentObject>();
        }
        T t = new T();
        childs.Add(t);
        return t;
    }
    public void RemoveComponent<T>() where T : ComponentObject
    {
        foreach (ComponentObject comp in childs)
        {
            if (comp is T)
            {
                childs.Remove(comp);
                return;
            }
        }

    }
    public T GetComponent<T>() where T : ComponentObject
    {
        foreach (ComponentObject comp in childs)
        {
            if (comp is T)
            {
                return comp as T;
            }
        }
        return null;
    }
    public T[] GetComponents<T>() where T : ComponentObject
    {
        List<T> list = new List<T>();
        foreach (ComponentObject comp in childs)
        {
            if (comp is T)
            {
                list.Add(comp as T);
            }
        }
        return list.ToArray();
    }
    public virtual void Start()
    {
        foreach (ComponentObject comp in childs)
        {
            comp.Start();
        }
    }
    public virtual void Update()
    {
        foreach (ComponentObject comp in childs)
        {
            comp.Update();
        }
    }
    public virtual void Dispose()
    {
        foreach (ComponentObject comp in childs)
        {
            comp.Dispose();
        }
        childs.Clear();
        childs = null;
    }
}


