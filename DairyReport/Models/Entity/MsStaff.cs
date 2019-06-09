using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DairyReport.Models.Entity
{
    public class MsStaff
    {
        /// <summary>
        /// 職員ID
        /// </summary>
        private int _staffID;

        /// <summary>
        /// 苗字
        /// </summary>
        private string _lastName;

        /// <summary>
        /// 名前
        /// </summary>
        private string _firstName;

        /// <summary>
        /// カナ苗字
        /// </summary>
        private string _kanaLastName;

        /// <summary>
        /// カナ名前
        /// </summary>
        private string _kanaFirstName;

        /// <summary>
        /// 在籍フラグ
        /// </summary>
        private int _eorolledFlag;

        /// <summary>
        /// 職種ID
        /// </summary>
        private int _occupationID;

        /// <summary>
        /// 職種ID
        /// </summary>
        private int _positionID;

        /// <summary>
        /// 登録日時
        /// </summary>
        private DateTime _insertDate;

        /// <summary>
        /// 登録ユーザー名
        /// </summary>
        private string _insertUserName;

        /// <summary>
        /// 登録コンピューター名
        /// </summary>
        private string _insertPCName;

        /// <summary>
        /// 更新日時
        /// </summary>
        private DateTime _updateDate;

        /// <summary>
        /// 更新ユーザー名
        /// </summary>
        private string _updateUserName;

        /// <summary>
        /// 更新コンピューター名
        /// </summary>
        private string _updatePCName;

        /// <summary>
        /// 削除日時
        /// </summary>
        private DateTime _deleteDate;

        /// <summary>
        /// 削除ユーザー名
        /// </summary>
        private string _deleteUserName;

        /// <summary>
        /// 削除コンピューター名
        /// </summary>
        private string _deletePCName;

        public int StaffID
        {
            get { return this._staffID; }
            set
            {
                this._staffID = value;
            }
        }


        public string LastName
        {
            get { return this._lastName; }
            set
            {
                this._lastName = value;
            }
        }

        public string FirstName
        {
            get { return this._firstName; }
            set
            {
                this._firstName = value;
            }
        }

        public string KanaLastName
        {
            get { return this._kanaLastName; }
            set
            {
                this._kanaLastName = value;
            }
        }

        public string KanaFirstName
        {
            get { return this._kanaFirstName; }
            set
            {
                this._kanaFirstName = value;
            }
        }

        public int EnrolledFlag
        {
            get { return this._eorolledFlag; }
            set
            {
                this._eorolledFlag = value;
            }
        }

        public int OccupationID
        {
            get { return this._occupationID; }
            set
            {
                this._occupationID = value;
            }
        }

        public int PositionID
        {
            get { return this._positionID; }
            set
            {
                this._positionID = value;
            }
        }

        public DateTime InserDate
        {
            get { return this._insertDate; }
            set
            {
                this._insertDate = value;
            }
        }

        public string InsertUserName
        {
            get { return this._insertUserName; }
            set
            {
                this._insertUserName = value;
            }
        }

        public string InsertPCName
        {
            get { return this._insertPCName; }
            set
            {
                this._insertPCName = value;
            }
        }

        public DateTime UpdateDate
        {
            get { return this._updateDate; }
            set
            {
                this._updateDate = value;
            }
        }

        public String UpdateUserName
        {
            get { return this._updateUserName; }
            set
            {
                this._updateUserName = value;
            }
        }

        public string UpdatePCName
        {
            get { return this._updatePCName; }
            set
            {
                this._updatePCName = value;
            }
        }

        public DateTime DeleteDate
        {
            get { return this._deleteDate; }
            set
            {
                this._deleteDate = value;
            }
        }
        public string DeleteUserName
        {
            get { return this._deleteUserName; }
            set
            {
                this._deleteUserName = value;
            }
        }

        public string DeletePCName
        {
            get
            {
                return this._deletePCName;
            }
            set
            {
                this._deletePCName = value;
            }
        }
    }
}