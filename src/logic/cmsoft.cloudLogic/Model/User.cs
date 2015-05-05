/*
* Copyright (c) Carlos Mario.
* Please, read the document https://github.com/carlosprogrammer/phonebook-service/blob/master/LICENSE
* of this code
*
*
*
*
*
*
*
*
* 
* 
* <carlos_programmer10@hotmail.com>
*/




using System;

namespace cmsoft.cloudLogic.Model
{
    /// <summary>
    /// The propietary of the phonebook
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class User
    {
        
        #region The attributes region

        /// <summary>
        /// The username of phonebook proprietary
        /// </summary>
        private String _strUserName;

        /// <summary>
        /// The name of phonebook proprietary
        /// </summary>
        private String _strName;

        /// <summary>
        /// The last name of phonebook proprietary
        /// </summary>
        private String _strLastName;

        /// <summary>
        /// The cell phone of phonebook proprietary
        /// </summary>
        private String _strCellPhone;

        /// <summary>
        /// The mail of phonebook proprietary
        /// </summary>
        private String _strMail;

        /// <summary>
        /// The password of phonebook proprietary
        /// </summary>
        private String _strPassword;

        #endregion



        #region The properties region


        /// <summary>
        /// Gets o sets the e-mail of phonebook proprietary
        /// </summary>
        public String Mail
        {
            get { return _strMail; }
            set { _strMail = value; }
        }

        /// <summary>
        /// Gets o sets the password of phonebook proprietary
        /// </summary>
        public String Password
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        /// <summary>
        /// Gets o sets the cell phone of phonebook proprietary
        /// </summary>
        public String CellPhone
        {
            get { return _strCellPhone; }
            set { _strCellPhone = value; }
        }

        /// <summary>
        /// Gets o sets the last name of phonebook proprietary
        /// </summary>
        public String LastName
        {
            get { return _strLastName; }
            set { _strLastName = value; }
        }

        /// <summary>
        /// Gets o sets the name of phonebook proprietary
        /// </summary>
        public String Name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        /// <summary>
        /// Gets o sets the username of phonebook proprietary
        /// </summary>
        public String UserName
        {
            get { return _strUserName; }
            set { _strUserName = value; }
        }

        #endregion
    }
}
