using System;
using System.Collections.Generic;
using System.Text;

namespace FucionalSqlLocal
{
    public static class FunctionalExtensions
    {
        public static T Tee<T>(this T @this, Action<T> action)
        {
            action(@this);
            return @this;
        }

        public static TResult Map<TSource, TResult>
        (
            this TSource @this,
            Func<TSource, TResult> fn)
        {
            return fn(@this);

        }
    }
}
