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
    /// The contact type.
    /// 
    /// It's a classification for each contact, example:
    /// The contacts in the university, the family, the wotk
    /// friends.
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class ContactType
    {

        #region The attributes region

        /// <summary>
        /// The type's is
        /// </summary>
        private int _intId;

        /// <summary>
        /// The type's name
        /// </summary>
        private String _strName;

        #endregion

        #region The region properties

        /// <summary>
        /// The type's picture:
        /// NOTE: This isn't an image, this is the image's url in the server.
        /// </summary>
        private String _strPicture;

        /// <summary>
        /// Gets or sets the image's url in the server.
        /// </summary>
        public String Picture
        {
            get { return _strPicture; }
            set { _strPicture = value; }
        }

        /// <summary>
        /// Gets or sets the type's name
        /// </summary>
        public String Name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        //// <summary>
        /// Gets or sets the type's id
        /// </summary>
        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        #endregion
    }
}