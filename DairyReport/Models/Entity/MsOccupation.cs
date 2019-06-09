﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DairyReport.Models.Entity
{
    public class MsOccupation
    {
        /// <summary>
        /// 職種ID
        /// </summary>
        private int _occupationID;

        /// <summary>
        /// 職種名
        /// </summary>
        private string _occupationName;

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

        public int OccupationID
        {
            get { return this._occupationID; }
            set
            {
                this._occupationID = value;
            }
        }

        public string OccupationName
        {
            get { return this._occupationName; }
            set
            {
                this._occupationName = value;
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