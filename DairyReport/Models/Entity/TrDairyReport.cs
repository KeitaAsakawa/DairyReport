using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DairyReport.Models.Entity
{
    public class TrDairyReport
    {
        /// <summary>
        /// 日報ID
        /// </summary>
        private int _dayShiftID;

        /// <summary>
        /// 日付
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// 日勤申し送り事項
        /// </summary>
        private string _dairySendOff;

        /// <summary>
        /// 指示変更検査
        /// </summary>
        private string _dailyInstructionChangeInspection;

        /// <summary>
        /// 日勤入院患者
        /// </summary>
        private string _dairyInpatient;

        /// <summary>
        /// 夜勤申し送り事項
        /// </summary>
        private string _nightSendOff;

        /// <summary>
        /// 夜勤指示変更検査
        /// </summary>
        private string _nightInstructionChangeInspection;

        /// <summary>
        /// 夜勤入院患者
        /// </summary>
        private string _nightInpatient;

        /// <summary>
        /// 外来申し送り事項
        /// </summary>
        private string _outpatientSendOff;

        /// <summary>
        /// メンテナンス申し送り事項
        /// </summary>
        private string _meintenancetSendOff;

        /// <summary>
        /// 特記申し送り事項
        /// </summary>
        private string _noticesSendOff;

        /// <summary>
        /// 準備室清掃
        /// </summary>
        private string _preparationRoom;

        /// <summary>
        /// 機械室清掃
        /// </summary>
        private string _machineRoom;

        /// <summary>
        /// 技師室清掃
        /// </summary>
        private string _technicianRoom;

        /// <summary>
        /// 翌日・日勤数
        /// </summary>
        private int _nextDay;

        /// <summary>
        /// 翌日・準夜数
        /// </summary>
        private int _nextNight;

        /// <summary>
        /// 翌日・合計
        /// </summary>
        private int _total;

        public int DayShiftID
        {
            get { return this._dayShiftID; }
            set
            {
                this._dayShiftID = value;
            }
        }

        public DateTime Date
        {
            get { return this._date; }
            set
            {
                this._date = value;
            }
        }

        public string DairySendOff
        {
            get { return this._dairySendOff; }
            set
            {
                this._dairySendOff = value;
            }
        }

        public string DailyInstructionChangeInspection
        {
            get { return this._dailyInstructionChangeInspection; }
            set
            {
                this._dailyInstructionChangeInspection = value;
            }
        }

        public string DailyInpatient
        {
            get { return this._dairyInpatient; }
            set
            {
                this._dairyInpatient = value;
            }
        }

        public string NightSendoff
        {
            get { return this._nightSendOff; }
            set
            {
                this._nightSendOff = value;
            }
        }

        public string NightInstructionChangeInspection
        {
            get { return this._nightInstructionChangeInspection; }
            set
            {
                this._nightInstructionChangeInspection = value;
            }
        }

        public string NightInpatient
        {
            get { return this._nightInpatient; }
            set
            {
                this._nightInpatient = value;
            }
        }

        public string OutpatientSendOff
        {
            get { return this._outpatientSendOff; }
            set
            {
                this._outpatientSendOff = value;
            }
        }

        public string MeintenancetSendOff
        {
            get { return this._meintenancetSendOff; }
            set
            {
                this._meintenancetSendOff = value;
            }
        }

        public string NoticesSendOff
        {
            get { return this._noticesSendOff; }
            set
            {
                this._noticesSendOff = value;
            }
        }

        public string PreparationRoom
        {
            get { return this._preparationRoom; }
            set
            {
                this._preparationRoom = value;
            }
        }

        public string MachineRoom
        {
            get { return this._machineRoom; }
            set
            {
                this._machineRoom = value;
            }
        }

        public string TechnicianRoom
        {
            get { return this._technicianRoom; }
            set
            {
                this._technicianRoom = value;
            }
        }

        public int NextDay
        {
            get { return this._nextDay; }
            set
            {
                this._nextDay = value;
            }
        }

        public int NextNight
        {
            get { return this._nextNight; }
            set
            {
                this._nextNight = value;
            }
        }

        public int Total
        {
            get { return this._total; }
            set
            {
                this._total = value;
            }
        }
    }
}