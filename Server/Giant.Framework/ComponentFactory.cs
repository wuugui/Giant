﻿using Giant.Core;
using System;

namespace Giant.Framework
{
    public class ComponentFactory
    {
        public static T CreateComponent<T>() where T : IInitSystem
        {
            T component = Activator.CreateInstance<T>();
            component.Init();
            return component;
        }

        public static T CreateComponent<T, T1>(T1 t1) where T : IInitSystem<T1>
        {
            T component = Activator.CreateInstance<T>();
            component.Init(t1);
            return component;
        }

        public static T CreateComponent<T, T1, T2>(T1 t1, T2 t2) where T : IInitSystem<T1, T2>
        {
            T component = Activator.CreateInstance<T>();
            component.Init(t1, t2);
            return component;
        }

        public static T CreateComponent<T, T1, T2, T3>(T1 t1, T2 t2, T3 t3) where T : IInitSystem<T1, T2, T3>
        {
            T component = Activator.CreateInstance<T>();
            component.Init(t1, t2, t3);
            return component;
        }

        public static T CreateComponent<T, T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4) where T : IInitSystem<T1, T2, T3, T4>
        {
            T component = Activator.CreateInstance<T>();
            component.Init(t1, t2, t3, t4);
            return component;
        }
    }
}
