﻿using System.ComponentModel.DataAnnotations;
using Sikiro.Common.Utils;

namespace Sikiro.Web.Admin.Attribute
{
    ///<summary>
    /// 中文
    /// </summary>
    public class ChineseAttribute : RegularExpressionAttribute
    {
        private const string RegexPattern = RegularExpression.Zhong;
        public ChineseAttribute()
            : base(RegexPattern)
        {
            ErrorMessage = "请输入中文";
        }
    }
}
