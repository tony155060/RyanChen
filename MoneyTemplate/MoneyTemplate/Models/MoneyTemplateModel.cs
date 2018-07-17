using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MoneyTemplate.Models
{
    public class MoneyTemplateModel
    {
        public enum EnumType
        {
            [Description("收入")]
            Income = 1,

            [Description("支出")]
            Outcome = 2
        }

        public class Money
        {
            /// <summary>
            /// 金額
            /// </summary>
            public int Quota { get; set; }

            /// <summary>
            /// 日期
            /// </summary>
            public DateTime InputDate { get; set; }

            /// <summary>
            /// 備註
            /// </summary>
            public string Memo { get; set; }

            /// <summary>
            /// 存入類型
            /// </summary>
            public EnumType Type { get; set; }
        }

        /// <summary>
        /// 記帳本列表
        /// </summary>
        public List<Money> MyMoneyList { get; set; }

        public void CreateData()
        {
            MyMoneyList = new List<Money>();

            for (int i = 1; i<51; i++)
            {
                var row = new Money
                {
                    Quota = i * 50,
                    InputDate = DateTime.Now.AddDays(i),
                    Type = i % 3 == 1 ? EnumType.Income : EnumType.Outcome
                };
                MyMoneyList.Add(row);
            }
        }
    }
}