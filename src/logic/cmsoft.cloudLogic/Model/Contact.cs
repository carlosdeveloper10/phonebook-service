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
    /// Represents a mobile contact
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class Contact
    {

        #region The attributes region

        /// <summary>
        /// The contact's id
        /// </summary>
        private int _intId;

        /// <summary>
        /// The contact's name
        /// </summary>
        private String _strName;

        /// <summary>
        /// The contact's last name
        /// </summary>
        private String _strLastName;

        /// <summary>
        /// The contact's nickname
        /// </summary>
        private String _strNickName;

        /// <summary>
        /// The contact's information or commentaries
        /// </summary>
        private String _strAbout;

        #endregion


        #region The properties region

        /// <summary>
        /// Gets o sets the contact's last name
        /// </summary>
        public String LastName
        {
            get { return _strLastName; }
            set { _strLastName = value; }
        }

        /// <summary>
        /// Gets o sets the contact's information
        /// </summary>
        public String About
        {
            get { return _strAbout; }
            set { _strAbout = value; }
        }

        /// <summary>
        /// Gets o sets the contact's nickname
        /// </summary>
        public String NickName
        {
            get { return _strNickName; }
            set { _strNickName = value; }
        }

        /// <summary>
        /// Gets o sets the contact's name
        /// </summary>
        public String Name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        /// <summary>
        /// Gets o sets the contact's id
        /// </summary>
        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        #endregion
    }
}
