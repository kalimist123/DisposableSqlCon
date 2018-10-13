using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FucionalSqlLocal
{
    public static class Disposable
    {
        public static TResult Using<TDisposable, TResult>
        (
            Func<TDisposable> factory,
            Func<TDisposable, TResult> fn)
            where TDisposable : IDisposable
        {
            using (var disposable = factory())
            {
                return fn(disposable);
            }
        }

       

    }
}
