using Castle.Core.Interceptor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
   public abstract class MethodInterception:MethodInterceptionBaseAttribute
    {
        protected virtual void OnBeform(IInvocation) { }
        protected virtual void OnAfter(IInvocation) { }
        protected virtual void OnException(IInvocation) { }
        protected virtual void OnSuccess(IInvocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBeform(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
                OnAfter(invocation);
            }
        }

    }
}
