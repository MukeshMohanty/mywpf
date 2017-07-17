using System;
using Microsoft.Practices.Unity;

namespace MyWpf.Infrastructure
{
    public static class UnityExtensions
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container)
        {
            container.RegisterType(typeof(object), typeof(T), typeof(T).FullName);
        }
    }
}