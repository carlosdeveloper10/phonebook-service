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
    /// The cell phone number for each contacts in the phonebook
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class CellPhoneNumber
    {

        #region The attributes region

        /// <summary>
        /// The number's id
        /// </summary>
        private int _intId;

        /// <summary>
        /// The cell phone number.
        /// </summary>
        private String _strNumber;

        #endregion

        #region The properties region

        /// <summary>
        /// Gets or sets the cell phone number
        /// </summary>
        public String Number
        {
            get { return _strNumber; }
            set { _strNumber = value; }
        }

        /// <summary>
        /// Gets or sets the number's id
        /// </summary>
        public int Id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        #endregion
    }
}
