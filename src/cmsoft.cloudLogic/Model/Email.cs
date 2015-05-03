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
    /// The contact's email account
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class Email
    {

        #region The attributes region

        /// <summary>
        /// The email's id
        /// </summary>
        private int _intId;

        /// <summary>
        /// The email account, example:
        /// 
        /// carlos@gmail.com, mario@developers.com
        /// </summary>
        private String _strAccount;

        #endregion


        #region The properties region

        /// <summary>
        /// Gets or sets the email's id
        /// </summary>
        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        /// <summary>
        /// Gets or sets the email account
        /// </summary>
        public String Account
        {
            get { return _strAccount; }
            set { _strAccount = value; }
        }

        #endregion
    }
}
