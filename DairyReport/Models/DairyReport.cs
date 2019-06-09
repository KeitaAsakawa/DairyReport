using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DairyReport.Models.Entity;

namespace DairyReport.Models
{
    public class DairyReport
    {
        /// <summary>
        /// 表示日付
        /// </summary>
        private DateTime _displayDate;

        /// <summary>
        /// 技師リスト todo　3つ持つ必要あるか検討が必要
        /// </summary>
        private List<MsStaff> _meStaffList;

        private TrDairyReport _trDairyReport;
    }
}