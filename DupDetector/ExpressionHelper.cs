using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public static class ExpressionHelper
    {
        public static string Name<T>(Expression<Func<T>> expression)
        {
            var lambda = expression as LambdaExpression;
            var memberExpression = (MemberExpression)lambda.Body;

            return memberExpression.Member.Name;
        }
    }
}
